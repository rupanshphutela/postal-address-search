using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddressManager_final.Models
{
    public class Address: IEquatable<Address>
    {
        public string buildingNumber { get; set; }
        public string streetName { get; set; }
        public string neighborhood { get; set; }
        public string quadrant { get; set; }
        public string city { get; set; }
        public string postalCode { get; set; }
        public string stateOrProvince { get; set; }
        public string country { get; set; }
        public string prefectureName { get; set; }
        public string subArea { get; set; }
        public string furtherSubArea { get; set; }
        public string block { get; set; }
        public string subdivisionOrPrecinct { get; set; }

        public bool Equals(Address other)
        {

            if (other == null)
            {
                return false;
            }

            bool buildingNumberSame;
            if (buildingNumber != null)
            {
                if (other.buildingNumber != null)
                {
                    buildingNumberSame = buildingNumber.ToLower().Contains(other.buildingNumber.ToLower());
                }
                else
                {
                    buildingNumberSame = true;
                }

            }
            else
            {
                if (other.buildingNumber == null || other.buildingNumber == "")
                {
                    buildingNumberSame = true;
                }
                else
                {
                    buildingNumberSame = false;
                }
            }



            bool streetNameSame;
            if (streetName != null)
            {
                if (other.streetName != null)
                {
                    streetNameSame = streetName.ToLower().Contains(other.streetName.ToLower());
                }
                else
                {
                    streetNameSame = true;
                }

            }
            else
            {
                if (other.streetName == null || other.streetName == "")
                {
                    streetNameSame = true;
                }
                else
                {
                    streetNameSame = false;
                }
            }




            bool neighborhoodSame;
            if (neighborhood != null)
            {
                if (other.neighborhood != null)
                {
                    neighborhoodSame = neighborhood.ToLower().Contains(other.neighborhood.ToLower());
                } else
                {
                    neighborhoodSame = true;
                }

            }
            else
            {
                if (other.neighborhood == null || other.neighborhood == "")
                {
                    neighborhoodSame = true;
                } else {
                    neighborhoodSame = false;
                }
            }

            bool quadrantSame;
            if (quadrant != null)
            {
                if (other.quadrant != null)
                {
                    quadrantSame = quadrant.ToLower().Contains(other.quadrant.ToLower());
                }
                else
                {
                    quadrantSame = true;
                }

            }
            else
            {
                if (other.quadrant == null || other.quadrant == "")
                {
                    quadrantSame = true;
                }
                else
                {
                    quadrantSame = false;
                }
            }

            bool citySame;
            if (city != null)
            {
                if (other.city != null)
                {
                    citySame = city.ToLower().Contains(other.city.ToLower());
                }
                else
                {
                    citySame = true;
                }

            }
            else
            {
                if (other.city == null || other.city == "")
                {
                    citySame = true;
                }
                else
                {
                    citySame = false;
                }
            }

            bool postalCodeSame;
            if (postalCode != null)
            {
                if (other.postalCode != null)
                {
                    postalCodeSame = postalCode.ToLower().Contains(other.postalCode.ToLower());
                }
                else
                {
                    postalCodeSame = true;
                }

            }
            else
            {
                if (other.postalCode == null || other.postalCode == "")
                {
                    postalCodeSame = true;
                }
                else
                {
                    postalCodeSame = false;
                }
            }

            bool stateOrProvinceSame;
            if (stateOrProvince != null)
            {
                if (other.stateOrProvince != null)
                {
                    stateOrProvinceSame = stateOrProvince.ToLower().Contains(other.stateOrProvince.ToLower());
                }
                else
                {
                    stateOrProvinceSame = true;
                }

            }
            else
            {
                if (other.stateOrProvince == null || other.stateOrProvince == "")
                {
                    stateOrProvinceSame = true;
                }
                else
                {
                    stateOrProvinceSame = false;
                }
            }

            bool countrySame;
            if (country != null)
            {
                if (other.country != null)
                {
                    countrySame = country.ToLower().Contains(other.country.ToLower());
                }
                else
                {
                    countrySame = true;
                }

            }
            else
            {
                if (other.country == null || other.country == "")
                {
                    countrySame = true;
                }
                else
                {
                    countrySame = false;
                }
            }


            bool prefectureNameSame;
            if (prefectureName != null)
            {
                if (other.prefectureName != null)
                {
                    prefectureNameSame = prefectureName.ToLower().Contains(other.prefectureName.ToLower());
                }
                else
                {
                    prefectureNameSame = true;
                }

            }
            else
            {
                if (other.prefectureName == null || other.prefectureName == "")
                {
                    prefectureNameSame = true;
                }
                else
                {
                    prefectureNameSame = false;
                }
            }

            bool subAreaSame;
            if (subArea != null)
            {
                if (other.subArea != null)
                {
                    subAreaSame = subArea.ToLower().Contains(other.subArea.ToLower());
                }
                else
                {
                    subAreaSame = true;
                }

            }
            else
            {
                if (other.subArea == null || other.subArea == "")
                {
                    subAreaSame = true;
                }
                else
                {
                    subAreaSame = false;
                }
            }

            bool furtherSubAreaSame;
            if (furtherSubArea != null)
            {
                if (other.furtherSubArea != null)
                {
                    furtherSubAreaSame = furtherSubArea.ToLower().Contains(other.furtherSubArea.ToLower());
                }
                else
                {
                    furtherSubAreaSame = true;
                }

            }
            else
            {
                if (other.furtherSubArea == null || other.furtherSubArea == "")
                {
                    furtherSubAreaSame = true;
                }
                else
                {
                    furtherSubAreaSame = false;
                }
            }


            bool blockSame;
            if (block != null)
            {
                if (other.block != null)
                {
                    blockSame = block.ToLower().Contains(other.block.ToLower());
                }
                else
                {
                    blockSame = true;
                }

            }
            else
            {
                if (other.block == null || other.block == "")
                {
                    blockSame = true;
                }
                else
                {
                    blockSame = false;
                }
            }


            bool subdivisionOrPrecinctSame;
            if (subdivisionOrPrecinct != null)
            {
                if (other.subdivisionOrPrecinct != null)
                {
                    subdivisionOrPrecinctSame = subdivisionOrPrecinct.ToLower().Contains(other.subdivisionOrPrecinct.ToLower());
                }
                else
                {
                    subdivisionOrPrecinctSame = true;
                }

            }
            else
            {
                if (other.subdivisionOrPrecinct == null || other.subdivisionOrPrecinct == "")
                {
                    subdivisionOrPrecinctSame = true;
                }
                else
                {
                    subdivisionOrPrecinctSame = false;
                }
            }



            return buildingNumberSame && 
                streetNameSame && 
                neighborhoodSame && 
                quadrantSame &&
                citySame &&
                postalCodeSame &&
                stateOrProvinceSame && 
                countrySame &&
                prefectureNameSame &&
                subAreaSame &&
                furtherSubAreaSame &&
                blockSame &&
                subdivisionOrPrecinctSame;
        }
    }
}
