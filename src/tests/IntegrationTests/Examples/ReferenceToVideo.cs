/*
order: 30
title: Reference to Video
slug: reference-to-video

Shows Vidu's differentiated Reference-to-Video feature - generating a video that
preserves the identity of multiple subjects supplied as reference images.
*/

namespace Vidu.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ReferenceToVideo()
    {
        using var client = GetAuthenticatedClient();

        //// Up to 7 reference images can be supplied; each is used as a subject reference
        //// that Vidu preserves across the generated frames.
        var task = await client.Generation.CreateReferenceToVideoTaskAsync(
            model: Model.Viduq3Turbo,
            prompt: "The two characters walk together through a neon-lit Tokyo street at night",
            images: new List<string>
            {
                "https://prod-file.vidu.studio/static/images/home/ref1.png",
                "https://prod-file.vidu.studio/static/images/home/ref2.png",
            },
            duration: 5,
            aspectRatio: AspectRatio.x16_9,
            resolution: Resolution.x720p);

        task.TaskId.Should().NotBeNullOrEmpty();
        Console.WriteLine($"Task ID: {task.TaskId}");
        Console.WriteLine($"State: {task.State}");
    }
}
