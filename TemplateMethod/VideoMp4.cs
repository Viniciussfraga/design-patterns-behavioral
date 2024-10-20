namespace TemplateMethod;

public class VideoMp4 : VideoPlayer
{
    public override void DecodeVideoFormato() => Console.WriteLine("O video está sendo processado com Decoder MP4");
}