﻿using System.Collections.Generic;
using Maxis.ViewModels;
using System.Data.Spatial;

namespace Maxis.Services.Abstract
{
    public interface IMapService
    {
        List<LrdViewModel> GetLrdValues(DbGeography searchPoint, int range);

        List<NeViewModel> GetNeNames(DbGeography searchPoint, int range, string lrd);

        List<ThresholdViewModel> GetThresholdDetails(string neName);

        List<CableViewModel> GetCables(DbGeography searchPoint, int range);

        List<CableViewModel> GetCableDetails(string cableType);

        List<BuildingViewModel> GetBuildingDetails(DbGeography searchPoint, int range);

        List<StructureViewmodel> GetStructureDetails(DbGeography searchPoint, int range);

    }
}
