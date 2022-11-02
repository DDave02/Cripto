using Cripto;

var nu = new MonoAlfabet();
nu.SetKey("EKLDPWHQRFXZYSIVGNMTCUJBAO");
nu.SetPlainText("Scrieti un program care sa implementeze urmatoare scheme de criptare clasica.");
Console.WriteLine(nu.Encrypt());
nu.SetPlainText("Mlnrptr cs vnihney lenp me ryvzpypstpop cnyetienp mlqpyp dp lnrvtenp lzemrle.");
Console.WriteLine(nu.Decrypt());