namespace Schmitt_GUI_FarmerChickenGrainGame
{
    internal static class FarmerUI
    {
        private static bool farmerSouth = false;
        private static bool foxSouth = false;
        private static bool chickenSouth = false;
        private static bool grainSouth = false;

        internal static void Reset()
        {
            farmerSouth = false;
            foxSouth = false;
            chickenSouth = false;
            grainSouth = false;
        }
        
        internal static bool GetAndUpdateFarmerPosition()
        {
            farmerSouth = !farmerSouth;
            return farmerSouth;
        }

        internal static bool GetAndUpdateFoxPosition()
        {
            foxSouth = !foxSouth;
            return foxSouth;
        }

        internal static bool GetAndUpdateChickenPosition()
        {
            chickenSouth = !chickenSouth;
            return chickenSouth;
        }

        internal static bool GetAndUpdateGrainPosition()
        {
            grainSouth = !grainSouth;
            return grainSouth;
        }

        internal static bool GetFarmerPosition()
        {
            return farmerSouth;
        }

        internal static bool GetFoxPosition()
        {
            return foxSouth;
        }

        internal static bool GetChickenPosition()
        {
            return chickenSouth;
        }

        internal static bool GetGrainPosition()
        {
            return grainSouth;
        }
    }
}
