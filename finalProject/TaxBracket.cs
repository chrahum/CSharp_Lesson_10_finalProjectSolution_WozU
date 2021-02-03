using System.Collections.Generic;

/// <summary>
/// Tax bracket rates are collected from: 
/// http://www.tax-rates.org/taxtables/income-tax-by-state 
/// </summary>


/*
 
To use: each even index is the taxt bracket and each odd index is its tax rate.
Iterate through the array two values at a time to work with both.
 
Example:
for (int i = decimalArray.Length - 2; i >= 0; i-=2)
{
    decimal taxBracket = decimalArray[i];
    decimal taxRate = decimalArray[i+1];
}
 
 */

namespace TaxBrackets
{
    public class Brackets
    {
        public static string[] StateList()
        {
            string[] stateList =
            {
                "Alabama", "Alaska", "Arizona", "Arkansas", "California", "Colorado",
                "Connecticut", "Delaware", "Florida", "Georgia", "Hawaii", "Idaho",
                "Illinois", "Indiana", "Iowa", "Kansas", "Kentucky", "Louisiana",
                "Maine", "Maryland", "Massachusetts", "Michigan", "Minnesota",
                "Mississippi", "Missouri", "Montana", "Nebraska", "Nevada", "New Hampshire",
                "New Jersey", "New Mexico", "New York", "North Carolina", "North Dakota",
                "Ohio", "Oklahoma", "Oregon", "Pennsylvania", "Rhode Island", "South Carolina",
                "South Dakota", "Tennessee", "Texas", "Utah", "Vermont", "Virginia", "Washington",
                "West Virginia", "Wisconsin", "Wyoming","West virginia","South dakota","Rhode island",
                "South carolina","New hampshire", "New jersey", "New mexico", "New york", 
                "North carolina", "North dakota"

            };

            return stateList;
        }
        public static Dictionary<string, decimal[]> Table()
        {
            Dictionary<string, decimal[]> table = new Dictionary<string, decimal[]>();

            table.Add("Alabama", new decimal[]
            {
                    0, 0.02M,
                  500, 0.04M,
                3_000, 0.05M,
            });

            table.Add("Alaska", new decimal[] { });

            table.Add("Arizona", new decimal[]
            {
                      0, 0.0259M,
                 26_500, 0.0334M,
                 53_000, 0.0417M,
                159_000, 0.0450M,
            });

            table.Add("Arkansas", new decimal[]
            {
                     0, 0.0200M,
                 4_000, 0.0400M,
                 8_000, 0.0590M,
                79_300, 0.0660M,
            });

            table.Add("California", new decimal[]
            {
                        0, 0.0100M,
                    8_809, 0.0200M,
                   20_883, 0.0400M,
                   32_960, 0.0600M,
                   45_753, 0.0800M,
                   57_824, 0.0930M,
                  295_373, 0.1030M,
                  354_445, 0.1130M,
                  590_742, 0.1230M,
                1_000_000, 0.1330M,
            });

            table.Add("Colorado", new decimal[] { 0, 0.0463M });

            table.Add("Connecticut", new decimal[]
            {
                      0, 0.0300M,
                 10_000, 0.0500M,
                 50_000, 0.0550M,
                100_000, 0.0600M,
                200_000, 0.0650M,
                250_000, 0.0690M,
                500_000, 0.0699M,
            });

            table.Add("Delaware", new decimal[]
            {
                 2_000, 0.0220M,
                 5_000, 0.0390M,
                10_000, 0.0480M,
                20_000, 0.0520M,
                25_000, 0.0555M,
                60_000, 0.0660M,
            });

            table.Add("Washington, D.C.", new decimal[]
            {
                        0, 0.0400M,
                   10_000, 0.0600M,
                   40_000, 0.0650M,
                   60_000, 0.0850M,
                  350_000, 0.0875M,
                1_000_000, 0.0895M,
            });

            table.Add("Florida", new decimal[] { });

            table.Add("Georgia", new decimal[]
            {
                    0, 0.0100M,
                  750, 0.0200M,
                2_250, 0.0300M,
                3_570, 0.0400M,
                5_250, 0.0500M,
                7_000, 0.0575M,
            });

            table.Add("Hawaii", new decimal[]
            {
                      0, 0.0140M,
                  2_400, 0.0320M,
                  4_800, 0.0550M,
                  9_600, 0.0640M,
                 14_400, 0.0680M,
                 19_200, 0.0720M,
                 24_000, 0.0760M,
                 36_000, 0.0790M,
                 48_000, 0.0825M,
                150_000, 0.0900M,
                175_000, 0.1000M,
                200_000, 0.1100M,
            });

            table.Add("Idaho", new decimal[]
            {
                     0, 0.0112M,
                 1_541, 0.0312M,
                 3_081, 0.0362M,
                 4_622, 0.0462M,
                 6_162, 0.0562M,
                 7_703, 0.0662M,
                11_554, 0.0692M,
            });

            table.Add("Illinois", new decimal[] { 0, 0.0495M, });

            table.Add("Indiana", new decimal[] { 0, 0.0323M, });

            table.Add("Iowa", new decimal[]
            {
                     0, 0.0033M,
                 1_638, 0.0067M,
                 3_276, 0.0225M,
                 6_552, 0.0414M,
                14_742, 0.0563M,
                24_570, 0.0596M,
                32_760, 0.0625M,
                49_140, 0.0744M,
                73_710, 0.0853M,
            });

            table.Add("Kansas", new decimal[]
            {
                     0, 0.0310M,
                15_000, 0.0525M,
                30_000, 0.0570M,
            });

            table.Add("Kentucky", new decimal[] { 0, 0.0495M, });

            table.Add("Louisiana", new decimal[]
            {
                     0, 0.0200M,
                12_500, 0.0400M,
                50_000, 0.0600M,
            });

            table.Add("Maine", new decimal[]
            {
                     0, 0.0580M,
                22_200, 0.0675M,
                52_600, 0.0715M,
            });

            table.Add("Maryland", new decimal[]
            {
                      0, 0.0200M,
                  1_000, 0.0300M,
                  2_000, 0.0400M,
                  3_000, 0.0475M,
                100_000, 0.0500M,
                125_000, 0.0525M,
                150_000, 0.0550M,
                250_000, 0.0575M,
            });

            table.Add("Massachusetts", new decimal[] { 0, 0.0500M, });

            table.Add("Michigan", new decimal[] { 0, 0.0425M, });

            table.Add("Minnesota", new decimal[]
            {
                      0, 0.0535M,
                 26_960, 0.0680M,
                 88_550, 0.0785M,
                164_400, 0.0985M,
            });

            table.Add("Mississippi", new decimal[]
            {
                 1_000, 0.0300M,
                 5_000, 0.0400M,
                10_000, 0.0500M,
            });

            table.Add("Missouri", new decimal[]
            {
                  105, 0.0150M,
                1_053, 0.0200M,
                2_106, 0.0250M,
                3_159, 0.0300M,
                4_212, 0.0350M,
                5_265, 0.0400M,
                6_318, 0.0450M,
                7_371, 0.0500M,
                8_424, 0.0540M,
            });

            table.Add("Montana", new decimal[]
            {
                     0, 0.0100M,
                 3_100, 0.0200M,
                 5_400, 0.0300M,
                 8_200, 0.0400M,
                11_100, 0.0500M,
                14_300, 0.0600M,
                18_400, 0.0690M,
            });

            table.Add("Nebraska", new decimal[]
            {
                     0, 0.0246M,
                 3_230, 0.0351M,
                19_330, 0.0501M,
                31_160, 0.0684M,
            });

            table.Add("Nevada", new decimal[] { });

            table.Add("New Hampshire", new decimal[] { 0, 0.0500M });

            table.Add("New hampshire", new decimal[] { 0, 0.0500M });

            table.Add("New Jersey", new decimal[]
            {
                        0, 0.0140M,
                   20_000, 0.0175M,
                   35_000, 0.0350M,
                   40_000, 0.0553M,
                   75_000, 0.0637M,
                  500_000, 0.0897M,
                5_000,000, 0.1075M,
            });

            table.Add("New jersey", new decimal[]
            {
                        0, 0.0140M,
                   20_000, 0.0175M,
                   35_000, 0.0350M,
                   40_000, 0.0553M,
                   75_000, 0.0637M,
                  500_000, 0.0897M,
                5_000,000, 0.1075M,
            });

            table.Add("New Mexico", new decimal[]
            {
                     0, 0.0170M,
                 5_500, 0.0320M,
                11_000, 0.0470M,
                16_000, 0.0490M,
            });

            table.Add("New mexico", new decimal[]
            {
                     0, 0.0170M,
                 5_500, 0.0320M,
                11_000, 0.0470M,
                16_000, 0.0490M,
            });

            table.Add("New York", new decimal[]
            {
                        0, 0.0400M,
                    8_500, 0.0450M,
                   11_700, 0.0525M,
                   13_900, 0.0590M,
                   21_400, 0.0621M,
                   80_650, 0.0649M,
                  215_400, 0.0685M,
                1_077_550, 0.0882M,
            });

            table.Add("New york", new decimal[]
            {
                        0, 0.0400M,
                    8_500, 0.0450M,
                   11_700, 0.0525M,
                   13_900, 0.0590M,
                   21_400, 0.0621M,
                   80_650, 0.0649M,
                  215_400, 0.0685M,
                1_077_550, 0.0882M,
            });

            table.Add("North Carolina", new decimal[] { 0, 0.0525M });
            table.Add("North carolina", new decimal[] { 0, 0.0525M });

            table.Add("North Dakota", new decimal[]
            {
                      0, 0.0110M,
                 39_450, 0.0204M,
                 95_500, 0.0227M,
                199_250, 0.0264M,
                433_200, 0.0290M,
            });

            table.Add("North dakota", new decimal[]
            {
                      0, 0.0110M,
                 39_450, 0.0204M,
                 95_500, 0.0227M,
                199_250, 0.0264M,
                433_200, 0.0290M,
            });

            table.Add("Ohio", new decimal[]
            {
                 21_750, 0.0285M,
                 43_450, 0.0333M,
                 86_900, 0.0380M,
                108_700, 0.0441M,
                217_400, 0.0480M,
            });

            table.Add("Oklahoma", new decimal[]
            {
                    0, 0.0050M,
                1_000, 0.0100M,
                2_500, 0.0200M,
                3_750, 0.0300M,
                4_900, 0.0400M,
                7_200, 0.0500M,
            });

            table.Add("Oregon", new decimal[] {
                      0, 0.0500M,
                  3_550, 0.0700M,
                  8_900, 0.0900M,
                125_000, 0.0990M,
            });

            table.Add("Pennsylvania", new decimal[] { 0, 0.0317M });

            table.Add("Rhode Island", new decimal[]
            {
                      0, 0.0375M,
                 65_250, 0.0475M,
                148_350, 0.0599M,
            });

            table.Add("Rhode island", new decimal[]
            {
                      0, 0.0375M,
                 65_250, 0.0475M,
                148_350, 0.0599M,
            });

            table.Add("South Carolina", new decimal[]
            {
                 3_070, 0.0300M,
                 6_150, 0.0400M,
                 9_230, 0.0500M,
                12_310, 0.0600M,
                15_400, 0.0700M,
            });

            table.Add("South Dakota", new decimal[] { });

            table.Add("South carolina", new decimal[]
            {
                 3_070, 0.0300M,
                 6_150, 0.0400M,
                 9_230, 0.0500M,
                12_310, 0.0600M,
                15_400, 0.0700M,
            });

            table.Add("South dakota", new decimal[] { });

            table.Add("Tennessee", new decimal[] { 0, 0.010M });

            table.Add("Texas", new decimal[] { });

            table.Add("Utah", new decimal[] { 0, 0.0495M });

            table.Add("Vermont", new decimal[]
            {
                      0, 0.0335M,
                 39_600, 0.0660M,
                 96_000, 0.0760M,
                200_200, 0.0875M,
            });

            table.Add("Virginia", new decimal[]
            {
                     0, 0.0200M,
                 3_000, 0.0300M,
                 5_000, 0.0500M,
                17_000, 0.0575M,
            });

            table.Add("Washington", new decimal[] { });

            table.Add("West Virginia", new decimal[]
            {
                     0, 0.0300M,
                10_000, 0.0400M,
                25_000, 0.0450M,
                40_000, 0.0600M,
                60_000, 0.0650M,
            });
            table.Add("West virginia", new decimal[]
           {
                     0, 0.0300M,
                10_000, 0.0400M,
                25_000, 0.0450M,
                40_000, 0.0600M,
                60_000, 0.0650M,
           });

            table.Add("Wisconsin", new decimal[]
            {
                      0, 0.0400M,
                 11_970, 0.0521M,
                 23_930, 0.0627M,
                263_480, 0.0765M,
            });

            table.Add("Wyoming", new decimal[] { });

            return table;
        }
    }
}