/*
order: 40
title: Start End to Video
slug: start-end-to-video

Shows how to generate a video that interpolates between a start frame and end frame.
*/

namespace Vidu.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task StartEndToVideo()
    {
        using var client = GetAuthenticatedClient();

        //// Provide exactly two images - the start frame and the end frame.
        //// Aspect ratios must be between 0.8 and 1.25 of each other.
        var task = await client.Generation.CreateStartEndToVideoTaskAsync(
            model: Model.Viduq3Turbo,
            images: new List<string>
            {
                "https://prod-file.vidu.studio/static/images/home/start.png",
                "https://prod-file.vidu.studio/static/images/home/end.png",
            },
            prompt: "Smooth transition with a subtle camera push-in",
            duration: 5,
            resolution: Resolution.x720p);

        task.TaskId.Should().NotBeNullOrEmpty();
        Console.WriteLine($"Task ID: {task.TaskId}");
    }
}
