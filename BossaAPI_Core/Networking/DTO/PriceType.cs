namespace BossaAPI_Core.DTO
{
    /// <summary>
    /// Typ wyliczeniowy używany w obiektach transportowych do przekazywania 
    /// (między modułami biblioteki) informacji o rodzaju zastosowanej w zleceniu ceny.
    /// </summary>
    public enum PriceType
	{
		Limit,
		PKC,
		PCR,
		PCRO,
	}
}
