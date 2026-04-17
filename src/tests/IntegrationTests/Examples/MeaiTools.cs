/*
order: 50
title: MEAI Tools
slug: meai-tools

Shows how to expose Vidu operations as Microsoft.Extensions.AI tools so any
IChatClient (OpenAI, Anthropic, etc.) can invoke them as function calls.
*/

using Microsoft.Extensions.AI;

namespace Vidu.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void MeaiTools()
    {
        //// Use a fake API key - we only exercise the tool builders, not the network.
        using var client = new ViduClient(apiKey: "test-key");

        //// Each helper returns an AIFunction that can be passed into ChatOptions.Tools.
        var textToVideo = client.AsTextToVideoTool();
        var imageToVideo = client.AsImageToVideoTool();
        var referenceToVideo = client.AsReferenceToVideoTool();
        var startEndToVideo = client.AsStartEndToVideoTool();
        var getTask = client.AsGetTaskCreationsTool();
        var upscale = client.AsUpscaleTool();

        var tools = new AIFunction[]
        {
            textToVideo, imageToVideo, referenceToVideo, startEndToVideo, getTask, upscale,
        };

        tools.Should().HaveCount(6);
        textToVideo.Name.Should().Be("TextToVideo");
        imageToVideo.Name.Should().Be("ImageToVideo");
        referenceToVideo.Name.Should().Be("ReferenceToVideo");
        startEndToVideo.Name.Should().Be("StartEndToVideo");
        getTask.Name.Should().Be("GetTaskCreations");
        upscale.Name.Should().Be("UpscaleVideo");
    }
}
