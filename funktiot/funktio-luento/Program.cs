int TulostaSanaJaPalautaSenPituus(string sana)
{
    Console.WriteLine(sana);
    int sanan_pituus = sana.Length;

    return sanan_pituus;
}

int pituus = TulostaSanaJaPalautaSenPituus("moro");
Console.WriteLine("pituus: " + pituus);

// tulosta_sana_ja_palauta_sen_pituus