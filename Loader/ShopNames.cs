using System;
using System.Collections.Generic;

namespace Loader
{
	public static class ShopNames
	{
		public static Dictionary<string, string> Lookup = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
		{
			{ "AdminOffice_Area18", "IO-North Tower, Area 18" },
			{ "AdminOffice_Grimhex", "Admin Office, GrimHEX" },
			{ "AdminOffice_Levski", "Admin Office, Levski" },
			{ "AdminOffice_Lorville", "L19 Admin Office, Lorville" },
			{ "AdminOffice_NewBabbage", "MT Planetary Services, New Babbage" },
			{ "AdminOffice_PortO", "Admin Office, Port Olisar" },
			{ "AdminOffice_Stanton1_L1", "Admin Office, HUR-L1" },
			{ "AdminOffice_Stanton1_L2", "Admin Office, HUR-L2" },
			{ "AdminOffice_Stanton1_L3", "Admin Office, HUR-L3" },
			{ "AdminOffice_Stanton1_L4", "Admin Office, HUR-L4" },
			{ "AdminOffice_Stanton1_L5", "Admin Office, HUR-L5" },
			{ "AdminOffice_Stanton1_LEO1", "Admin Office, Everus Harbor" },
			{ "AdminOffice_Stanton2_L1", "Admin Office, CRU-L1" },
			{ "AdminOffice_Stanton2_L4", "Shallow Fields Station Admin Office, CRU-L4 (removed)" },
			{ "AdminOffice_Stanton2_L5", "Admin Office, CRU-L5" },
			{ "AdminOffice_Stanton3_L1", "Admin Office, ARC-L1" },
			{ "AdminOffice_Stanton3_LEO1", "Admin Office, Baijini Point" },
			{ "AdminOffice_Stanton4_L1", "Admin Office, MIC-L1" },
			{ "AdminOffice_Stanton4_LEO1", " Admin Office, Port Tressler" },
			{ "arccorp_cluster_001_frost", "ArcCorp Mining Area 157" },
			{ "arccorp_cluster_001_sand", "ArcCorp Mining Area 141" },
			{ "drug_farm_001_frost", "Jumptown" },
			{ "DrugLab_Stanton3a_ParadiseCove", "Paradise Cove" },
			{ "Fence_Junkyard_Stanton1_1", "Fence Junkyard" },
			{ "Fence_Junkyard_Stanton2b_1", "Brio's Breaker Yard" },
			{ "Fence_Junkyard_Stanton3b_1", "Samson & Son's Salvage Center" },
			{ "Fence_RestStop2_4", "Reclamation & Disposal Orinth (Junkyard)" },
			{ "Fence_RestStop2_5", "Locker Room, CRU-L5" },
			{ "indy_farmer_001_dust", "Gallete Family Farms" },
			{ "indy_farmer_001_sand", "Bountiful Harvest Hydroponics" },
			{ "indy_miner_001_dust", "Tram & Meyers Mining" },
			{ "indy_miner_001_frost", "Benson Mining Outpost" },
			{ "indy_miner_001_sand", "Kudre Ore" },
			{ "Klescher_Aberdeen", "Klescher Prison Commissary" },
			{ "MiningKiosks_Area18", "Refining Terminal, Area 18" },
			{ "MiningKiosks_GrimHex", "Refining Terminal, GrimHEX" },
			{ "rayari_cluster_001_dust", "Hickes Research Outpost" },
			{ "rayari_cluster_001_frost", "Deakins Research Outpost" },
			{ "shubin_cluster_001_sand", "Shubin Mining Facility SCD-1" },
			{ "stanton_1_hrst_001", "HDMS Edmond" },
			{ "stanton_1_hrst_002", "HDMS Oparei" },
			{ "stanton_1_hrst_003", "HDMS Pinewood" },
			{ "stanton_1_hrst_004", "HDMS Thedus" },
			{ "stanton_1_hrst_005", "HDMS Hadley" },
			{ "stanton_1_hrst_006", "HDMS Stanhope" },
			{ "stanton_1a_hrst_001", "HDMS Bezdek" },
			{ "stanton_1a_hrst_002", "HDMS Lathan" },
			{ "stanton_1b_hrst_001", "HDMS Norgaard" },
			{ "stanton_1b_hrst_002", "HDMS Anderson" },
			{ "stanton_1c_hrst_001", "HDMS Hahn" },
			{ "stanton_1c_hrst_002", "HMDS Perlman" },
			{ "stanton_1d_hrst_001", "HDMS Woodruff" },
			{ "stanton_1d_hrst_002", "HDMS Ryder" },
			{ "stanton_3a_indy_humboldt", "Humbolt Mines" },
			{ "stanton_3a_indy_loveridge", "Loveridge Mineral Reserve" },
			{ "stanton_3a_shubin_sal2", "Shubin Mining Facility SAL-2" },
			{ "stanton_3a_shubin_sal5", "Shubin Mining Facility SAL-5" },
			{ "stanton_3b_arccorp_area045", "ArcCorp mining Area 45" },
			{ "stanton_3b_arccorp_area048", "ArcCorp mining Area 48" },
			{ "stanton_3b_arccorp_area056", "ArcCorp mining Area 56" },
			{ "stanton_3b_arccorp_area061", "ArcCorp mining Area 61" },
			{ "stanton_3b_indyFarm_001", "Shady Glen Farms" },
			{ "stanton_4_rayari_001", "Rayari Deltana Research Outpost" },
			{ "stanton_4a_drugfarm_001", "Raven's Roost" },
			{ "stanton_4a_rayari_001", "Rayari Anvik Research Outpost" },
			{ "stanton_4a_rayari_002", "Rayari Kaltag Research Outpost" },
			{ "stanton_4a_shubin_001", "Shubin Mining Facility SMCa-6" },
			{ "stanton_4a_shubin_002", "Shubin Mining Facility SMCa-8" },
			{ "stanton_4b_rayari_001", "Rayari Cantwell Research Outpost" },
			{ "stanton_4b_rayari_002", "Rayari McGrath Research Outpost" },
			{ "stanton_4c_indyFarm_001", "Bud's Growery" },
			{ "StashHouse_Stanton2a_PrivateProperty", "Private Property" },
			{ "StashHouse_Stanton2b_NuenWaste", "Nuen Waste Management" },
			{ "StashHouse_Stanton2c_NT999XX", "NT-999-XX" },
			{ "StashHouse_Stanton3a_Orphanage", "The Orphanage" },
			{ "StashHouse_Stanton4", "Cellin Stash House" },
			{ "t_mills_cluster_001_dust", "Terra Mills Hydro Farm" },
			{ "TDD_Area18", "Trade & Development Division, Area 18" },
			{ "TDD_NewBabbage", "Trade & Development Division, New Babbage" },
			{ "Transfers_Lorville", "Lorville CBD (In Transfers Room)" },
			{ "Fence_Junkyard_Stanton4c_1", "Devlin Scrap & Salvage" },
			{ "CubbyBlast_Area18", "Cubby Blast, Area 18"},
			{ "GarrityDefense_PortO", "Garrity Defense, Port Olisar"},
			{ "Centermass_Area18", "Centermass, Area 18" },
			{ "Centermass_NewBabbage", "Centermass, New Babbage" },
			{ "DumpersDepot_PortO", "Dumper's Depot, Port Olisar" },
			{ "DumpersDepot_Area18", "Dumper's Depot, Area 18" },
			{ "DumpersDepot_Grimhex", "Dumper's Depot, GrimHEX" },
			{ "DumpersDepot_Levski", "Dumper's Depot, Levski" },
			{ "PlatinumBay_Stanton1_LEO1", "Platinum Bay, Everus Harbor" },
			{ "PlatinumBay_Stanton3_LEO1", "Platinum Bay, Baijini Point" },
			{ "Skutters_Food_GrimHex", "Skutters, GrimHEX"},
			{ "ConscientiousObjects_Levski", "Conscientious Objects, Levski"},
			{ "Market_ClothingStand_Levski", "Market Clothing Stand, Levski"},
			{ "MiningKiosks_Levski", "Mining Kiosks, Levski" },
			{ "MiningKiosks_Olisar", "Mining Kiosks, Port Olisar" },
			{ "MiningKiosks_Lorville", "Mining Kiosks, Lorville" },
			{ "MiningKiosks_NewBabbage", "Mining Kiosks, New Babbage" },
			{ "LandingServices_Olisar", "Landing Services, Port Olisar" },
			{ "LandingServices_Levski", "Landing Services, Levski" },
			{ "LandingServices_GrimHex", "Landing Services, GrimHEX" },
			{ "LandingServices_Lorville", "Landing Services, Lorville" },
			{ "LandingServices_Area18", "Landing Services, Area 18" },
			{ "TammanyAndSons_Lorville", "Tammany & Sons, Lorville" },
			{ "NewDeal_Lorville", "New Deal, Lorville" },
			{ "TeachsShipShop_Levski", "Teach's Ship Shop, Levski" },
			{ "AstroArmada_Area18", "Astro Armada, Area 18" },
			{ "HDShowcase_Lorville", "Hurston Dynamics Showcase, Lorville" },
			{ "FactoryLine_NewBabbage", "Factory Line, New Babbage" },
			{ "TravelerRentals_Area18", "Traveler Rentals, Area 18" },
			{ "VantageRentals_Lorville", "Vantage Rentals, Lorville" },
			{ "RegalLuxury_NewBabbage", "Regal Luxury, New Babbage" },
			{ "Aparelli_NewBabbage", "Aparelli, New Babbage" },
			{ "OmegaPro_NewBabbage", "Omega Pro, New Babbage" },
			{ "ShubinInterstellar_NewBabbage", "Shubin Interstellar, New Babbage" }
		};
	}
}
