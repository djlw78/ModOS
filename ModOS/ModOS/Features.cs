using System.Collections.Generic;

using ModOS.Interface;

namespace ModOS {
	public class Features {
		List<IFeature> _Features = new List<IFeature>();

		public IFeature this[string index] {
			get {
				foreach (IFeature feature in _Features) {
					if (feature.GetInformation().Name.ToLower() == index.ToLower())
						return feature;
				}

				return null;
			}
		}
		public void addFeature(IFeature feature) {
			feature.Initialise();
            _Features.Add(feature);
		}
	}
}