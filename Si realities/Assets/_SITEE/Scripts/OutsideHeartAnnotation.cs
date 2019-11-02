using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutsideHeartAnnotation : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject FunFacts;

    //OutsideInfoPanel
    public GameObject LeftAtrium;
    public GameObject RightAtrium;
    public GameObject LeftVentricle;
    public GameObject RightVentricle;
    public GameObject PulmonaryTrunk;
    public GameObject LeftPulmonaryVeins;
    public GameObject LeftPulmonaryArtery;
    public GameObject AorticArch;
    public GameObject LeftCommonCarotidArtery;
    public GameObject BrachiocephalicArtery;
    public GameObject LeftSubclavianArtery;
    public GameObject SuperiorVenaCava;
    //public GameObject Rightpulmonaryartery;
    public GameObject InferiorVenaCava;
    public GameObject Apex;

    //OutsideLabels
    public GameObject LeftAtriumLabel;
    public GameObject RightAtriumLabel;
    public GameObject LeftVentricleLabel;
    public GameObject RightVentricleLabel;
    public GameObject PulmonaryTrunkLabel;
    public GameObject LeftPulmonaryVeinsLabel;
    public GameObject LeftPulmonaryArteryLabel;
    public GameObject AorticArchLabel;
    public GameObject LeftCommonCarotidArteryLabel;
    public GameObject BrachiocephalicArteryLabel;
    public GameObject LeftSubclavianArteryLabel;
    public GameObject SuperiorVenaCavaLabel;
    //public GameObject RightpulmonaryarteryLabel;
    public GameObject InferiorVenaCavaLabel;
    public GameObject ApexLabel;

   
    void OnMouseDown()
    {

        if (gameObject.name == "OutsideLeftAtrium")
        {
            FunFacts.SetActive(false);
            LeftAtrium.SetActive(true);
            RightAtrium.SetActive(false);
            LeftVentricle.SetActive(false);
            RightVentricle.SetActive(false);
            PulmonaryTrunk.SetActive(false);
            LeftPulmonaryVeins.SetActive(false);
            LeftPulmonaryArtery.SetActive(false);
            AorticArch.SetActive(false);
            LeftCommonCarotidArtery.SetActive(false);
            BrachiocephalicArtery.SetActive(false);
            LeftSubclavianArtery.SetActive(false);
            SuperiorVenaCava.SetActive(false);
            //Rightpulmonaryartery.SetActive(false);
            InferiorVenaCava.SetActive(false);
            Apex.SetActive(false);

            LeftAtriumLabel.SetActive(true);
            RightAtriumLabel.SetActive(false);
            LeftVentricleLabel.SetActive(false);
            RightVentricleLabel.SetActive(false);
            PulmonaryTrunkLabel.SetActive(false);
            LeftPulmonaryVeinsLabel.SetActive(false);
            LeftPulmonaryArteryLabel.SetActive(false);
            AorticArchLabel.SetActive(false);
            LeftCommonCarotidArteryLabel.SetActive(false);
            BrachiocephalicArteryLabel.SetActive(false);
            LeftSubclavianArteryLabel.SetActive(false);
            SuperiorVenaCavaLabel.SetActive(false);
           // RightpulmonaryarteryLabel.SetActive(false);
            InferiorVenaCavaLabel.SetActive(false);
            ApexLabel.SetActive(false);

        }

        if (gameObject.name == "OutsideRightAtrium")
        {
            FunFacts.SetActive(false);
            LeftAtrium.SetActive(false);
            RightAtrium.SetActive(true);
            LeftVentricle.SetActive(false);
            RightVentricle.SetActive(false);
            PulmonaryTrunk.SetActive(false);
            LeftPulmonaryVeins.SetActive(false);
            LeftPulmonaryArtery.SetActive(false);
            AorticArch.SetActive(false);
            LeftCommonCarotidArtery.SetActive(false);
            BrachiocephalicArtery.SetActive(false);
            LeftSubclavianArtery.SetActive(false);
            SuperiorVenaCava.SetActive(false);
           // Rightpulmonaryartery.SetActive(false);
            InferiorVenaCava.SetActive(false);
            Apex.SetActive(false);

            LeftAtriumLabel.SetActive(false);
            RightAtriumLabel.SetActive(true);
            LeftVentricleLabel.SetActive(false);
            RightVentricleLabel.SetActive(false);
            PulmonaryTrunkLabel.SetActive(false);
            LeftPulmonaryVeinsLabel.SetActive(false);
            LeftPulmonaryArteryLabel.SetActive(false);
            AorticArchLabel.SetActive(false);
            LeftCommonCarotidArteryLabel.SetActive(false);
            BrachiocephalicArteryLabel.SetActive(false);
            LeftSubclavianArteryLabel.SetActive(false);
            SuperiorVenaCavaLabel.SetActive(false);
           // RightpulmonaryarteryLabel.SetActive(false);
            InferiorVenaCavaLabel.SetActive(false);
            ApexLabel.SetActive(false);

        }
        if (gameObject.name == "OutsideLeftVentricle")
        {
            FunFacts.SetActive(false);
            LeftAtrium.SetActive(false);
            RightAtrium.SetActive(false);
            LeftVentricle.SetActive(true);
            RightVentricle.SetActive(false);
            PulmonaryTrunk.SetActive(false);
            LeftPulmonaryVeins.SetActive(false);
            LeftPulmonaryArtery.SetActive(false);
            AorticArch.SetActive(false);
            LeftCommonCarotidArtery.SetActive(false);
            BrachiocephalicArtery.SetActive(false);
            LeftSubclavianArtery.SetActive(false);
            SuperiorVenaCava.SetActive(false);
            //Rightpulmonaryartery.SetActive(false);
            InferiorVenaCava.SetActive(false);
            Apex.SetActive(false);

            LeftAtriumLabel.SetActive(false);
            RightAtriumLabel.SetActive(false);
            LeftVentricleLabel.SetActive(true);
            RightVentricleLabel.SetActive(false);
            PulmonaryTrunkLabel.SetActive(false);
            LeftPulmonaryVeinsLabel.SetActive(false);
            LeftPulmonaryArteryLabel.SetActive(false);
            AorticArchLabel.SetActive(false);
            LeftCommonCarotidArteryLabel.SetActive(false);
            BrachiocephalicArteryLabel.SetActive(false);
            LeftSubclavianArteryLabel.SetActive(false);
            SuperiorVenaCavaLabel.SetActive(false);
           // RightpulmonaryarteryLabel.SetActive(false);
            InferiorVenaCavaLabel.SetActive(false);
            ApexLabel.SetActive(false);

        }

        if (gameObject.name == "OutsideRightVentricle")
        {
            FunFacts.SetActive(false);
            LeftAtrium.SetActive(false);
            RightAtrium.SetActive(false);
            LeftVentricle.SetActive(false);
            RightVentricle.SetActive(true);
            PulmonaryTrunk.SetActive(false);
            LeftPulmonaryVeins.SetActive(false);
            LeftPulmonaryArtery.SetActive(false);
            AorticArch.SetActive(false);
            LeftCommonCarotidArtery.SetActive(false);
            BrachiocephalicArtery.SetActive(false);
            LeftSubclavianArtery.SetActive(false);
            SuperiorVenaCava.SetActive(false);
            //Rightpulmonaryartery.SetActive(false);
            InferiorVenaCava.SetActive(false);
            Apex.SetActive(false);

            LeftAtriumLabel.SetActive(false);
            RightAtriumLabel.SetActive(false);
            LeftVentricleLabel.SetActive(false);
            RightVentricleLabel.SetActive(true);
            PulmonaryTrunkLabel.SetActive(false);
            LeftPulmonaryVeinsLabel.SetActive(false);
            LeftPulmonaryArteryLabel.SetActive(false);
            AorticArchLabel.SetActive(false);
            LeftCommonCarotidArteryLabel.SetActive(false);
            BrachiocephalicArteryLabel.SetActive(false);
            LeftSubclavianArteryLabel.SetActive(false);
            SuperiorVenaCavaLabel.SetActive(false);
            //RightpulmonaryarteryLabel.SetActive(false);
            InferiorVenaCavaLabel.SetActive(false);
            ApexLabel.SetActive(false);
        }

        if (gameObject.name == "OutsidePulmonaryTrunk")
        {
            FunFacts.SetActive(false);
            LeftAtrium.SetActive(false);
            RightAtrium.SetActive(false);
            LeftVentricle.SetActive(false);
            RightVentricle.SetActive(false);
            PulmonaryTrunk.SetActive(true);
            LeftPulmonaryVeins.SetActive(false);
            LeftPulmonaryArtery.SetActive(false);
            AorticArch.SetActive(false);
            LeftCommonCarotidArtery.SetActive(false);
            BrachiocephalicArtery.SetActive(false);
            LeftSubclavianArtery.SetActive(false);
            SuperiorVenaCava.SetActive(false);
            //Rightpulmonaryartery.SetActive(false);
            InferiorVenaCava.SetActive(false);
            Apex.SetActive(false);

            LeftAtriumLabel.SetActive(false);
            RightAtriumLabel.SetActive(false);
            LeftVentricleLabel.SetActive(false);
            RightVentricleLabel.SetActive(false);
            PulmonaryTrunkLabel.SetActive(true);
            LeftPulmonaryVeinsLabel.SetActive(false);
            LeftPulmonaryArteryLabel.SetActive(false);
            AorticArchLabel.SetActive(false);
            LeftCommonCarotidArteryLabel.SetActive(false);
            BrachiocephalicArteryLabel.SetActive(false);
            LeftSubclavianArteryLabel.SetActive(false);
            SuperiorVenaCavaLabel.SetActive(false);
            //RightpulmonaryarteryLabel.SetActive(false);
            InferiorVenaCavaLabel.SetActive(false);
            ApexLabel.SetActive(false);
        }

        if (gameObject.name == "OutsideLeftPulmonaryVeins")
        {
            FunFacts.SetActive(false);
            LeftAtrium.SetActive(false);
            RightAtrium.SetActive(false);
            LeftVentricle.SetActive(false);
            RightVentricle.SetActive(false);
            PulmonaryTrunk.SetActive(false);
            LeftPulmonaryVeins.SetActive(true);
            LeftPulmonaryArtery.SetActive(false);
            AorticArch.SetActive(false);
            LeftCommonCarotidArtery.SetActive(false);
            BrachiocephalicArtery.SetActive(false);
            LeftSubclavianArtery.SetActive(false);
            SuperiorVenaCava.SetActive(false);
            //Rightpulmonaryartery.SetActive(false);
            InferiorVenaCava.SetActive(false);
            Apex.SetActive(false);

            LeftAtriumLabel.SetActive(false);
            RightAtriumLabel.SetActive(false);
            LeftVentricleLabel.SetActive(false);
            RightVentricleLabel.SetActive(false);
            PulmonaryTrunkLabel.SetActive(false);
            LeftPulmonaryVeinsLabel.SetActive(true);
            LeftPulmonaryArteryLabel.SetActive(false);
            AorticArchLabel.SetActive(false);
            LeftCommonCarotidArteryLabel.SetActive(false);
            BrachiocephalicArteryLabel.SetActive(false);
            LeftSubclavianArteryLabel.SetActive(false);
            SuperiorVenaCavaLabel.SetActive(false);
            //RightpulmonaryarteryLabel.SetActive(false);
            InferiorVenaCavaLabel.SetActive(false);
            ApexLabel.SetActive(false);
        }
        if (gameObject.name == "OutsideLeftPulmonaryArtery")
        {
            FunFacts.SetActive(false);
            LeftAtrium.SetActive(false);
            RightAtrium.SetActive(false);
            LeftVentricle.SetActive(false);
            RightVentricle.SetActive(false);
            PulmonaryTrunk.SetActive(false);
            LeftPulmonaryVeins.SetActive(false);
            LeftPulmonaryArtery.SetActive(true);
            AorticArch.SetActive(false);
            LeftCommonCarotidArtery.SetActive(false);
            BrachiocephalicArtery.SetActive(false);
            LeftSubclavianArtery.SetActive(false);
            SuperiorVenaCava.SetActive(false);
            //Rightpulmonaryartery.SetActive(false);
            InferiorVenaCava.SetActive(false);
            Apex.SetActive(false);

            LeftAtriumLabel.SetActive(false);
            RightAtriumLabel.SetActive(false);
            LeftVentricleLabel.SetActive(false);
            RightVentricleLabel.SetActive(false);
            PulmonaryTrunkLabel.SetActive(false);
            LeftPulmonaryVeinsLabel.SetActive(false);
            LeftPulmonaryArteryLabel.SetActive(true);
            AorticArchLabel.SetActive(false);
            LeftCommonCarotidArteryLabel.SetActive(false);
            BrachiocephalicArteryLabel.SetActive(false);
            LeftSubclavianArteryLabel.SetActive(false);
            SuperiorVenaCavaLabel.SetActive(false);
            //RightpulmonaryarteryLabel.SetActive(false);
            InferiorVenaCavaLabel.SetActive(false);
            ApexLabel.SetActive(false);
        }

        if (gameObject.name == "OutsideAorticarch")
        {
            FunFacts.SetActive(false);
            LeftAtrium.SetActive(false);
            RightAtrium.SetActive(false);
            LeftVentricle.SetActive(false);
            RightVentricle.SetActive(false);
            PulmonaryTrunk.SetActive(false);
            LeftPulmonaryVeins.SetActive(false);
            LeftPulmonaryArtery.SetActive(false);
            AorticArch.SetActive(true);
            LeftCommonCarotidArtery.SetActive(false);
            BrachiocephalicArtery.SetActive(false);
            LeftSubclavianArtery.SetActive(false);
            SuperiorVenaCava.SetActive(false);
            //Rightpulmonaryartery.SetActive(false);
            InferiorVenaCava.SetActive(false);
            Apex.SetActive(false);

            LeftAtriumLabel.SetActive(false);
            RightAtriumLabel.SetActive(false);
            LeftVentricleLabel.SetActive(false);
            RightVentricleLabel.SetActive(false);
            PulmonaryTrunkLabel.SetActive(false);
            LeftPulmonaryVeinsLabel.SetActive(false);
            LeftPulmonaryArteryLabel.SetActive(false);
            AorticArchLabel.SetActive(true);
            LeftCommonCarotidArteryLabel.SetActive(false);
            BrachiocephalicArteryLabel.SetActive(false);
            LeftSubclavianArteryLabel.SetActive(false);
            SuperiorVenaCavaLabel.SetActive(false);
            //RightpulmonaryarteryLabel.SetActive(false);
            InferiorVenaCavaLabel.SetActive(false);
            ApexLabel.SetActive(false);
        }

        if (gameObject.name == "OutsideLeftCommonCarotidArtery")
        {
            FunFacts.SetActive(false);
            LeftAtrium.SetActive(false);
            RightAtrium.SetActive(false);
            LeftVentricle.SetActive(false);
            RightVentricle.SetActive(false);
            PulmonaryTrunk.SetActive(false);
            LeftPulmonaryVeins.SetActive(false);
            LeftPulmonaryArtery.SetActive(false);
            AorticArch.SetActive(false);
            LeftCommonCarotidArtery.SetActive(true);
            BrachiocephalicArtery.SetActive(false);
            LeftSubclavianArtery.SetActive(false);
            SuperiorVenaCava.SetActive(false);
            //Rightpulmonaryartery.SetActive(false);
            InferiorVenaCava.SetActive(false);
            Apex.SetActive(false);

            LeftAtriumLabel.SetActive(false);
            RightAtriumLabel.SetActive(false);
            LeftVentricleLabel.SetActive(false);
            RightVentricleLabel.SetActive(false);
            PulmonaryTrunkLabel.SetActive(false);
            LeftPulmonaryVeinsLabel.SetActive(false);
            LeftPulmonaryArteryLabel.SetActive(false);
            AorticArchLabel.SetActive(false);
            LeftCommonCarotidArteryLabel.SetActive(true);
            BrachiocephalicArteryLabel.SetActive(false);
            LeftSubclavianArteryLabel.SetActive(false);
            SuperiorVenaCavaLabel.SetActive(false);
           //RightpulmonaryarteryLabel.SetActive(false);
            InferiorVenaCavaLabel.SetActive(false);
            ApexLabel.SetActive(false);
        }

        if (gameObject.name == "OutsideBrachiocephalicArtery")
        {
            FunFacts.SetActive(false);
            LeftAtrium.SetActive(false);
            RightAtrium.SetActive(false);
            LeftVentricle.SetActive(false);
            RightVentricle.SetActive(false);
            PulmonaryTrunk.SetActive(false);
            LeftPulmonaryVeins.SetActive(false);
            LeftPulmonaryArtery.SetActive(false);
            AorticArch.SetActive(false);
            LeftCommonCarotidArtery.SetActive(false);
            BrachiocephalicArtery.SetActive(true);
            LeftSubclavianArtery.SetActive(false);
            SuperiorVenaCava.SetActive(false);
            //Rightpulmonaryartery.SetActive(false);
            InferiorVenaCava.SetActive(false);
            Apex.SetActive(false);

            LeftAtriumLabel.SetActive(false);
            RightAtriumLabel.SetActive(false);
            LeftVentricleLabel.SetActive(false);
            RightVentricleLabel.SetActive(false);
            PulmonaryTrunkLabel.SetActive(false);
            LeftPulmonaryVeinsLabel.SetActive(false);
            LeftPulmonaryArteryLabel.SetActive(false);
            AorticArchLabel.SetActive(false);
            LeftCommonCarotidArteryLabel.SetActive(false);
            BrachiocephalicArteryLabel.SetActive(true);
            LeftSubclavianArteryLabel.SetActive(false);
            SuperiorVenaCavaLabel.SetActive(false);
            //RightpulmonaryarteryLabel.SetActive(false);
            InferiorVenaCavaLabel.SetActive(false);
            ApexLabel.SetActive(false);


        }

        if (gameObject.name == "OutsideLeftSubclavianArtery")
        {
            FunFacts.SetActive(false);
            LeftAtrium.SetActive(false);
            RightAtrium.SetActive(false);
            LeftVentricle.SetActive(false);
            RightVentricle.SetActive(false);
            PulmonaryTrunk.SetActive(false);
            LeftPulmonaryVeins.SetActive(false);
            LeftPulmonaryArtery.SetActive(false);
            AorticArch.SetActive(false);
            LeftCommonCarotidArtery.SetActive(false);
            BrachiocephalicArtery.SetActive(false);
            LeftSubclavianArtery.SetActive(true);
            SuperiorVenaCava.SetActive(false);
            //Rightpulmonaryartery.SetActive(false);
            InferiorVenaCava.SetActive(false);
            Apex.SetActive(false);

            LeftAtriumLabel.SetActive(false);
            RightAtriumLabel.SetActive(false);
            LeftVentricleLabel.SetActive(false);
            RightVentricleLabel.SetActive(false);
            PulmonaryTrunkLabel.SetActive(false);
            LeftPulmonaryVeinsLabel.SetActive(false);
            LeftPulmonaryArteryLabel.SetActive(false);
            AorticArchLabel.SetActive(false);
            LeftCommonCarotidArteryLabel.SetActive(false);
            BrachiocephalicArteryLabel.SetActive(false);
            LeftSubclavianArteryLabel.SetActive(true);
            SuperiorVenaCavaLabel.SetActive(false);
            //RightpulmonaryarteryLabel.SetActive(false);
            InferiorVenaCavaLabel.SetActive(false);
            ApexLabel.SetActive(false);

        }

        if (gameObject.name == "OutsideSuperiorVenaCava")
        {
            FunFacts.SetActive(false);
            LeftAtrium.SetActive(false);
            RightAtrium.SetActive(false);
            LeftVentricle.SetActive(false);
            RightVentricle.SetActive(false);
            PulmonaryTrunk.SetActive(false);
            LeftPulmonaryVeins.SetActive(false);
            LeftPulmonaryArtery.SetActive(false);
            AorticArch.SetActive(false);
            LeftCommonCarotidArtery.SetActive(false);
            BrachiocephalicArtery.SetActive(false);
            LeftSubclavianArtery.SetActive(false);
            SuperiorVenaCava.SetActive(true);
           // Rightpulmonaryartery.SetActive(false);
            InferiorVenaCava.SetActive(false);
            Apex.SetActive(false);

            LeftAtriumLabel.SetActive(false);
            RightAtriumLabel.SetActive(false);
            LeftVentricleLabel.SetActive(false);
            RightVentricleLabel.SetActive(false);
            PulmonaryTrunkLabel.SetActive(false);
            LeftPulmonaryVeinsLabel.SetActive(false);
            LeftPulmonaryArteryLabel.SetActive(false);
            AorticArchLabel.SetActive(false);
            LeftCommonCarotidArteryLabel.SetActive(false);
            BrachiocephalicArteryLabel.SetActive(false);
            LeftSubclavianArteryLabel.SetActive(false);
            SuperiorVenaCavaLabel.SetActive(true);
            //RightpulmonaryarteryLabel.SetActive(false);
            InferiorVenaCavaLabel.SetActive(false);
            ApexLabel.SetActive(false);

        }
        if (gameObject.name == "OutsideRightpulmonaryartery")
        {
            FunFacts.SetActive(false);
            LeftAtrium.SetActive(false);
            RightAtrium.SetActive(false);
            LeftVentricle.SetActive(false);
            RightVentricle.SetActive(false);
            PulmonaryTrunk.SetActive(false);
            LeftPulmonaryVeins.SetActive(false);
            LeftPulmonaryArtery.SetActive(false);
            AorticArch.SetActive(false);
            LeftCommonCarotidArtery.SetActive(false);
            BrachiocephalicArtery.SetActive(false);
            LeftSubclavianArtery.SetActive(false);
            SuperiorVenaCava.SetActive(false);
            //Rightpulmonaryartery.SetActive(true);
            InferiorVenaCava.SetActive(false);
            Apex.SetActive(false);

            LeftAtriumLabel.SetActive(false);
            RightAtriumLabel.SetActive(false);
            LeftVentricleLabel.SetActive(false);
            RightVentricleLabel.SetActive(false);
            PulmonaryTrunkLabel.SetActive(false);
            LeftPulmonaryVeinsLabel.SetActive(false);
            LeftPulmonaryArteryLabel.SetActive(false);
            AorticArchLabel.SetActive(false);
            LeftCommonCarotidArteryLabel.SetActive(false);
            BrachiocephalicArteryLabel.SetActive(false);
            LeftSubclavianArteryLabel.SetActive(false);
            SuperiorVenaCavaLabel.SetActive(false);
            //RightpulmonaryarteryLabel.SetActive(true);
            InferiorVenaCavaLabel.SetActive(false);
            ApexLabel.SetActive(false);

        }


        if (gameObject.name == "OutsideInferiorVenaCava")
        {
            FunFacts.SetActive(false);
            LeftAtrium.SetActive(false);
            RightAtrium.SetActive(false);
            LeftVentricle.SetActive(false);
            RightVentricle.SetActive(false);
            PulmonaryTrunk.SetActive(false);
            LeftPulmonaryVeins.SetActive(false);
            LeftPulmonaryArtery.SetActive(false);
            AorticArch.SetActive(false);
            LeftCommonCarotidArtery.SetActive(false);
            BrachiocephalicArtery.SetActive(false);
            LeftSubclavianArtery.SetActive(false);
            SuperiorVenaCava.SetActive(false);
            //Rightpulmonaryartery.SetActive(false);
            InferiorVenaCava.SetActive(true);
            Apex.SetActive(false);

            LeftAtriumLabel.SetActive(false);
            RightAtriumLabel.SetActive(false);
            LeftVentricleLabel.SetActive(false);
            RightVentricleLabel.SetActive(false);
            PulmonaryTrunkLabel.SetActive(false);
            LeftPulmonaryVeinsLabel.SetActive(false);
            LeftPulmonaryArteryLabel.SetActive(false);
            AorticArchLabel.SetActive(false);
            LeftCommonCarotidArteryLabel.SetActive(false);
            BrachiocephalicArteryLabel.SetActive(false);
            LeftSubclavianArteryLabel.SetActive(false);
            SuperiorVenaCavaLabel.SetActive(false);
           // RightpulmonaryarteryLabel.SetActive(false);
            InferiorVenaCavaLabel.SetActive(true);
            ApexLabel.SetActive(false);

        }

        if (gameObject.name == "OutsideApex")
        {
            FunFacts.SetActive(false);
            LeftAtrium.SetActive(false);
            RightAtrium.SetActive(false);
            LeftVentricle.SetActive(false);
            RightVentricle.SetActive(false);
            PulmonaryTrunk.SetActive(false);
            LeftPulmonaryVeins.SetActive(false);
            LeftPulmonaryArtery.SetActive(false);
            AorticArch.SetActive(false);
            LeftCommonCarotidArtery.SetActive(false);
            BrachiocephalicArtery.SetActive(false);
            LeftSubclavianArtery.SetActive(false);
            SuperiorVenaCava.SetActive(false);
            //Rightpulmonaryartery.SetActive(false);
            InferiorVenaCava.SetActive(false);
            Apex.SetActive(true);

            LeftAtriumLabel.SetActive(false);
            RightAtriumLabel.SetActive(false);
            LeftVentricleLabel.SetActive(false);
            RightVentricleLabel.SetActive(false);
            PulmonaryTrunkLabel.SetActive(false);
            LeftPulmonaryVeinsLabel.SetActive(false);
            LeftPulmonaryArteryLabel.SetActive(false);
            AorticArchLabel.SetActive(false);
            LeftCommonCarotidArteryLabel.SetActive(false);
            BrachiocephalicArteryLabel.SetActive(false);
            LeftSubclavianArteryLabel.SetActive(false);
            SuperiorVenaCavaLabel.SetActive(false);
            //RightpulmonaryarteryLabel.SetActive(false);
            InferiorVenaCavaLabel.SetActive(false);
            ApexLabel.SetActive(true);

        }




    }
}
