using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp.Model
{
    internal class GuitarSpec
    {
        private string _model;
        public GuitarType GuitarType { get; set; }
        public Builder Builder { get; set; }
        public Wood BackWood { get; set; }
        public Wood TopWood { get; set; }

        private int _numStrings;
        public Builder GetBuilder()
        {
            return Builder;
        }
        public string GetModel()
        {
            return _model;
        }
        public GuitarType GetType()
        {
            return GuitarType;
        }
        public Wood GetBackWood()
        {
            return BackWood;
        }
        public Wood GetTopWood()
        {
            return TopWood;
        }
        public int GetNumStrings()
        {
            return _numStrings;
        }
        public GuitarSpec(Builder builder, string model, GuitarType guitarType,int numStrings, Wood backWood, Wood topWood)
        {
            Builder = builder;
            _model = model;
            GuitarType = guitarType;
            _numStrings = numStrings;
            BackWood = backWood;
            TopWood = topWood;
        }
        public bool Matches(GuitarSpec otherSpec)
        {
            if (Builder != otherSpec.Builder)
                return false;
            if (!string.IsNullOrEmpty(_model) && !_model.Equals(otherSpec._model, StringComparison.OrdinalIgnoreCase))
                return false;
            if (GuitarType != otherSpec.GuitarType)
                return false;
            if (_numStrings != otherSpec._numStrings)
                return false;
            if (BackWood != otherSpec.BackWood)
                return false;
            if (TopWood != otherSpec.TopWood)
                return false;
            return true;
        }
    }
}
