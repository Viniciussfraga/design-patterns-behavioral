using TemplateMethod;

VideoPlayer arquivoVideo = new VideoMp4();
arquivoVideo.CarregarArquivo();
arquivoVideo.DecodeVideoFormato();
arquivoVideo.IniciarExecucao();

arquivoVideo = new VideoMkv();
arquivoVideo.CarregarArquivo();
arquivoVideo.DecodeVideoFormato();
arquivoVideo.IniciarExecucao();