/*
order: 20
title: Image to Video
slug: image-to-video

Shows how to animate a single reference image into a short video clip.
*/

namespace Vidu.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ImageToVideo()
    {
        using var client = GetAuthenticatedClient();

        //// Provide a publicly reachable image URL. Base64 data URIs are also accepted.
        var task = await client.Generation.CreateImageToVideoTaskAsync(
            model: Model.Viduq3Turbo,
            images: new List<string> { "https://prod-file.vidu.studio/static/images/home/sample.png" },
            prompt: "The subject gently turns its head and smiles",
            duration: 5,
            resolution: Resolution.x720p);

        task.TaskId.Should().NotBeNullOrEmpty();
        Console.WriteLine($"Task ID: {task.TaskId}");
        Console.WriteLine($"State: {task.State}");
    }
}
