﻿namespace pjank.BossaAPI.DTO
{
    /// <summary>
    /// Obiekt transportowy do przekazywania (między modułami biblioteki) aktualizacji stanu notowań rynkowych.
    /// Dotyczy zawsze konkretnego instrumentu, a pozostałe pola - wypełnione zależnie od rodzaju danego update'a.
    /// </summary>
    public class MarketData
	{
		public Instrument Instrument;
		public MarketOfferData BuyOffer;
		public MarketOfferData SellOffer;
		public MarketTradeData Trade;
		public MarketStatsData Stats;
		public uint? OpenInt;
	}
}
