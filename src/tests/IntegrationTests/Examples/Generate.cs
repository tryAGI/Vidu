/*
order: 10
title: Text to Video
slug: text-to-video

Shows how to submit a text-to-video generation task with Vidu and poll for the result.
*/

namespace Vidu.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task TextToVideo()
    {
        using var client = GetAuthenticatedClient();

        //// Submit a text-to-video generation task with viduq3-turbo at 720p.
        var task = await client.Generation.CreateTextToVideoTaskAsync(
            model: Model.Viduq3Turbo,
            prompt: "A golden retriever running through a sunlit meadow in cinematic slow motion",
            duration: 5,
            aspectRatio: AspectRatio.x16_9,
            resolution: Resolution.x720p);

        task.TaskId.Should().NotBeNullOrEmpty();
        task.State.Should().NotBeNull();
        Console.WriteLine($"Task ID: {task.TaskId}");
        Console.WriteLine($"State: {task.State}");

        //// Poll the task until it reaches a terminal state (success/failed).
        var creations = await client.Tasks.GetTaskCreationsAsync(id: task.TaskId!);
        creations.State.Should().NotBeNull();
        Console.WriteLine($"Creations state: {creations.State}");

        //// When the task succeeds, the result contains one or more creation URLs valid for 24 hours.
        if (creations.State == TaskState.Success && creations.Creations is { Count: > 0 })
        {
            Console.WriteLine($"Video URL: {creations.Creations[0].Url}");
        }
    }
}
