using System.Runtime.CompilerServices;
using Unity.Entities;
using UnityEngine.Scripting;
using Game;

namespace NoPet;

[CompilerGenerated]
public class NoPetSystem : GameSystemBase
{
    
    
    public override int GetUpdateInterval(SystemUpdatePhase phase)
    {
        return 16;
    }

    [Preserve]
    protected override void OnCreate()
    {
        //base.OnCreate();
        //this.m_SimulationSystem = base.World.GetOrCreateSystemManaged<SimulationSystem>();
        //this.m_EndFrameBarrier = base.World.GetOrCreateSystemManaged<EndFrameBarrier>();
        //this.m_HouseholdPetQuery = base.GetEntityQuery(ComponentType.ReadOnly<HouseholdPet>(), ComponentType.ReadOnly<UpdateFrame>(), ComponentType.Exclude<Deleted>(), ComponentType.Exclude<Temp>());
        //base.RequireForUpdate(this.m_HouseholdPetQuery);
    }

    [Preserve]
    protected override void OnUpdate()
    {
        /*uint updateFrame;
        updateFrame = SimulationUtils.GetUpdateFrame(this.m_SimulationSystem.frameIndex, 16);
        this.m_HouseholdPetQuery.SetSharedComponentFilter(new UpdateFrame(updateFrame));
        this.__TypeHandle.__Game_Citizens_HouseholdCitizen_RO_BufferLookup.Update(ref base.CheckedStateRef);
        this.__TypeHandle.__Game_Buildings_PropertyRenter_RO_ComponentLookup.Update(ref base.CheckedStateRef);
        this.__TypeHandle.__Game_Citizens_CurrentBuilding_RO_ComponentLookup.Update(ref base.CheckedStateRef);
        this.__TypeHandle.__Game_Creatures_GroupMember_RO_ComponentLookup.Update(ref base.CheckedStateRef);
        this.__TypeHandle.__Game_Citizens_TouristHousehold_RO_ComponentLookup.Update(ref base.CheckedStateRef);
        this.__TypeHandle.__Game_Citizens_Household_RO_ComponentLookup.Update(ref base.CheckedStateRef);
        this.__TypeHandle.__Game_Common_Deleted_RO_ComponentLookup.Update(ref base.CheckedStateRef);
        this.__TypeHandle.__EntityStorageInfoLookup.Update(ref base.CheckedStateRef);
        this.__TypeHandle.__Game_Common_Target_RO_ComponentTypeHandle.Update(ref base.CheckedStateRef);
        this.__TypeHandle.__Game_Citizens_CurrentBuilding_RO_ComponentTypeHandle.Update(ref base.CheckedStateRef);
        this.__TypeHandle.__Game_Citizens_CurrentTransport_RO_ComponentTypeHandle.Update(ref base.CheckedStateRef);
        this.__TypeHandle.__Game_Citizens_HouseholdPet_RO_ComponentTypeHandle.Update(ref base.CheckedStateRef);
        this.__TypeHandle.__Unity_Entities_Entity_TypeHandle.Update(ref base.CheckedStateRef);
        HouseholdPetTickJob jobData;
        jobData = default(HouseholdPetTickJob);
        jobData.m_EntityType = this.__TypeHandle.__Unity_Entities_Entity_TypeHandle;
        jobData.m_HouseholdPetType = this.__TypeHandle.__Game_Citizens_HouseholdPet_RO_ComponentTypeHandle;
        jobData.m_CurrentTransportType = this.__TypeHandle.__Game_Citizens_CurrentTransport_RO_ComponentTypeHandle;
        jobData.m_CurrentBuildingType = this.__TypeHandle.__Game_Citizens_CurrentBuilding_RO_ComponentTypeHandle;
        jobData.m_TargetType = this.__TypeHandle.__Game_Common_Target_RO_ComponentTypeHandle;
        jobData.m_EntityLookup = this.__TypeHandle.__EntityStorageInfoLookup;
        jobData.m_DeletedData = this.__TypeHandle.__Game_Common_Deleted_RO_ComponentLookup;
        jobData.m_HouseholdData = this.__TypeHandle.__Game_Citizens_Household_RO_ComponentLookup;
        jobData.m_TouristHouseholdData = this.__TypeHandle.__Game_Citizens_TouristHousehold_RO_ComponentLookup;
        jobData.m_GroupMemberData = this.__TypeHandle.__Game_Creatures_GroupMember_RO_ComponentLookup;
        jobData.m_CurrentBuildingData = this.__TypeHandle.__Game_Citizens_CurrentBuilding_RO_ComponentLookup;
        jobData.m_PropertyRenterData = this.__TypeHandle.__Game_Buildings_PropertyRenter_RO_ComponentLookup;
        jobData.m_HouseholdCitizens = this.__TypeHandle.__Game_Citizens_HouseholdCitizen_RO_BufferLookup;
        jobData.m_CommandBuffer = this.m_EndFrameBarrier.CreateCommandBuffer().AsParallelWriter();
        JobHandle jobHandle;
        jobHandle = JobChunkExtensions.ScheduleParallel(jobData, this.m_HouseholdPetQuery, base.Dependency);
        this.m_EndFrameBarrier.AddJobHandleForProducer(jobHandle);
        base.Dependency = jobHandle;*/
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void __AssignQueries(ref SystemState state)
    {
    }

    protected override void OnCreateForCompiler()
    {
        //base.OnCreateForCompiler();
        //this.__AssignQueries(ref base.CheckedStateRef);
        //this.__TypeHandle.__AssignHandles(ref base.CheckedStateRef);
    }

    [Preserve]
    public NoPetSystem()
    {
    }
}
