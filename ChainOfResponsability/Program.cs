using ChainOfResponsability;

GerenteProjeto gp = new();
SupervisorEquipe se = new();
SetorRh sr = new();

gp.ProximoAutorizador(se);
se.ProximoAutorizador(sr);

gp.AutorizarLicenca("Vini", 5);
gp.AutorizarLicenca("Vinicius", 14);
gp.AutorizarLicenca("Fraga", 18);
gp.AutorizarLicenca("Santos", 30);
gp.AutorizarLicenca("Vineeeeeeee", 50);

Console.ReadLine();
