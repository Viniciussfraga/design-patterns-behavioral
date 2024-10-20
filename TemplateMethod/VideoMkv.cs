namespace TemplateMethod;

public class VideoMkv : VideoPlayer
{
    public override void DecodeVideoFormato() => Console.WriteLine("O video está sendo processado com Decoder MKV");
}