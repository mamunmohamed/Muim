﻿
using Muim.Data.Contracts;
using Muim.Domain.Context;
using Muim.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace Muim.Data.Implemention
{
    public class ClassCharacterCpacidadesData : IClassCharacterCpacidadesData
    {
        private readonly IContextDb _contextDb;
        public ClassCharacterCpacidadesData(IContextDb contextDb)
        {
            _contextDb = contextDb;
        }

        public bool AddClassCharacterCapacidades(ClassCharacterCapacidades classCharacterCpacidades)
        {
            _contextDb.ClassCharacterCpacidades.Add(classCharacterCpacidades);
            return true;
        }
        public bool DeleteClassCharacterCapacidades(ClassCharacterCapacidades classCharacterCpacidades)
        {
            _contextDb.ClassCharacterCpacidades.Remove(classCharacterCpacidades);
            return true;
        }
        public List<ClassCharacterCapacidades> GetClassCharacterCapacidades(int classcharacterId)
        {
            var classCharacterCpacidades = _contextDb.ClassCharacterCpacidades.Where(x => x.ClassCharacterId == classcharacterId).ToList();
            return classCharacterCpacidades;
        }
    }
}
