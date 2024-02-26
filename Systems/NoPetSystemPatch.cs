using Game;
using Game.Simulation;
using HarmonyLib;

namespace NoPet.Systems
{
    /*[HarmonyPatch(typeof(HouseholdPetBehaviorSystem), "OnCreate")]
    public class HouseholdPetBehaviorSystem_OnCreatePatch
    {
        private static bool Prefix(HouseholdPetBehaviorSystem __instance)
        {
            __instance.World.GetOrCreateSystemManaged<NoPetSystem>();
            __instance.World.GetOrCreateSystemManaged<UpdateSystem>().UpdateAt<NoPetSystem>(SystemUpdatePhase.GameSimulation);
            return true;
        }
    }

    [HarmonyPatch(typeof(HouseholdPetBehaviorSystem), "OnCreateForCompiler")]
    public class HouseholdPetBehaviorSystem_OnCreateForCompilerPatch
    {
        private static bool Prefix(HouseholdPetBehaviorSystem __instance)
        {
            return false;
        }
    }

    [HarmonyPatch(typeof(HouseholdPetBehaviorSystem), "OnUpdate")]
    public class HouseholdPetBehaviorSystem_OnUpdatePatch
    {
        private static bool Prefix(HouseholdPetBehaviorSystem __instance)
        {
            __instance.World.GetOrCreateSystemManaged<NoPetSystem>().Update();
            return false;
        }
    }*/

    /*[HarmonyPatch(typeof(PetAISystem), "OnCreate")]
public class PetAISystem_OnCreatePatch
{
    private static bool Prefix(PetAISystem __instance)
    {
        __instance.World.GetOrCreateSystemManaged<NoPetSystem>();
        __instance.World.GetOrCreateSystemManaged<UpdateSystem>().UpdateAt<NoPetSystem>(SystemUpdatePhase.GameSimulation);
        return true;
    }
}

[HarmonyPatch(typeof(PetAISystem), "OnCreateForCompiler")]
public class PetAISystem_OnCreateForCompilerPatch
{
    private static bool Prefix(PetAISystem __instance)
    {
        return false;
    }
}

[HarmonyPatch(typeof(PetAISystem), "OnUpdate")]
public class PetAISystem_OnUpdatePatch
{
    private static bool Prefix(PetAISystem __instance)
    {
        __instance.World.GetOrCreateSystemManaged<NoPetSystem>().Update();
        return false;
    }
}*/


    [HarmonyPatch(typeof(HouseholdPetSpawnSystem), "OnCreate")]
    public class HouseholdPetSpawnSystem_OnCreatePatch
    {
        private static bool Prefix(HouseholdPetSpawnSystem __instance)
        {
            __instance.World.GetOrCreateSystemManaged<NoPetSystem>();
            __instance.World.GetOrCreateSystemManaged<UpdateSystem>().UpdateAt<NoPetSystem>(SystemUpdatePhase.GameSimulation);
            return true;
        }
    }

    [HarmonyPatch(typeof(HouseholdPetSpawnSystem), "OnCreateForCompiler")]
    public class HouseholdPetSpawnSystem_OnCreateForCompilerPatch
    {
        private static bool Prefix(HouseholdPetSpawnSystem __instance)
        {
            return false;
        }
    }

    [HarmonyPatch(typeof(HouseholdPetSpawnSystem), "OnUpdate")]
    public class HouseholdPetSpawnSystem_OnUpdatePatch
    {
        private static bool Prefix(HouseholdPetSpawnSystem __instance)
        {
            __instance.World.GetOrCreateSystemManaged<NoPetSystem>().Update();
            return false;
        }
    }



}