using TimelessCollection.Extensions;
using Kingmaker.Blueprints;
using Kingmaker.Blueprints.Classes;
using Kingmaker.Blueprints.Classes.Selection;

namespace TimelessCollection.Feats
{
    static class BloodriderMount
    {
        public static void AddBloodriderMount()
        {
            var BloodriderMountSelection = Resources.GetBlueprint<BlueprintFeatureSelection>("c81bb2aa48c113c4ba3ee8582eb058ea");

            var AnimalCompanionFeatureBear = Resources.GetBlueprint<BlueprintFeature>("f6f1cdcc404f10c4493dc1e51208fd6f");
            var AnimalCompanionFeatureBoar = Resources.GetBlueprint<BlueprintFeature>("afb817d80b843cc4fa7b12289e6ebe3d");
            var AnimalCompanionFeatureCentipede = Resources.GetBlueprint<BlueprintFeature>("f9ef7717531f5914a9b6ecacfad63f46");
            var AnimalCompanionFeatureDog = Resources.GetBlueprint<BlueprintFeature>("f894e003d31461f48a02f5caec4e3359");
            var AnimalCompanionFeatureElk = Resources.GetBlueprint<BlueprintFeature>("aa92fea676be33d4dafd176d699d7996");
            var AnimalCompanionFeatureLeopard = Resources.GetBlueprint<BlueprintFeature>("2ee2ba60850dd064e8b98bf5c2c946ba");
            var AnimalCompanionFeatureMastodon = Resources.GetBlueprint<BlueprintFeature>("6adc3aab7cde56b40aa189a797254271");
            var AnimalCompanionFeatureMonitor = Resources.GetBlueprint<BlueprintFeature>("ece6bde3dfc76ba4791376428e70621a");
            var AnimalCompanionFeatureSmilodon = Resources.GetBlueprint<BlueprintFeature>("126712ef923ab204983d6f107629c895");
            var AnimalCompanionFeatureSmilodon_PreorderBonus = Resources.GetBlueprint<BlueprintFeature>("44f4d77689434e07a5a44dcb65b25f71");
            var AnimalCompanionFeatureTriceratops = Resources.GetBlueprint<BlueprintFeature>("2d3f409bb0956d44187e9ec8340163f8");
            var AnimalCompanionFeatureTriceratops_PreorderBonus = Resources.GetBlueprint<BlueprintFeature>("52c854f77105445a9457572ab5826c00");
            var AnimalCompanionFeatureVelociraptor = Resources.GetBlueprint<BlueprintFeature>("89420de28b6bb9443b62ce489ae5423b");
            var AnimalCompanionFeatureWolf = Resources.GetBlueprint<BlueprintFeature>("67a9dc42b15d0954ca4689b13e8dedea");

            BloodriderMountSelection.m_AllFeatures = BloodriderMountSelection.m_AllFeatures.AppendToArray(AnimalCompanionFeatureBear.ToReference<BlueprintFeatureReference>(),
                                                                                                          AnimalCompanionFeatureBoar.ToReference<BlueprintFeatureReference>(),
                                                                                                          AnimalCompanionFeatureCentipede.ToReference<BlueprintFeatureReference>(),
                                                                                                          AnimalCompanionFeatureDog.ToReference<BlueprintFeatureReference>(),
                                                                                                          AnimalCompanionFeatureElk.ToReference<BlueprintFeatureReference>(),
                                                                                                          AnimalCompanionFeatureLeopard.ToReference<BlueprintFeatureReference>(),
                                                                                                          AnimalCompanionFeatureMastodon.ToReference<BlueprintFeatureReference>(),
                                                                                                          AnimalCompanionFeatureMonitor.ToReference<BlueprintFeatureReference>(),
                                                                                                          AnimalCompanionFeatureSmilodon.ToReference<BlueprintFeatureReference>(),
                                                                                                          AnimalCompanionFeatureSmilodon_PreorderBonus.ToReference<BlueprintFeatureReference>(),
                                                                                                          AnimalCompanionFeatureTriceratops.ToReference<BlueprintFeatureReference>(),
                                                                                                          AnimalCompanionFeatureTriceratops_PreorderBonus.ToReference<BlueprintFeatureReference>(),
                                                                                                          AnimalCompanionFeatureVelociraptor.ToReference<BlueprintFeatureReference>(),
                                                                                                          AnimalCompanionFeatureWolf.ToReference<BlueprintFeatureReference>());
        }
    }
}
