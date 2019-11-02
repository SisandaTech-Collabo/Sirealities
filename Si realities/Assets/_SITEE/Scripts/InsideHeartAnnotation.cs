using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsideHeartAnnotation : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject FunFacts;

    //InsideInfoPanel
    public GameObject LeftAtrium;
    public GameObject RightAtrium;
    public GameObject LeftVentricle;
    public GameObject RightVentricle;
    public GameObject PulmonarySemilunarValve;
    public GameObject LeftPulmonaryVeins;
    public GameObject LeftPulmonaryArtery;
    public GameObject Aorta;
   // public GameObject LeftCommonCarotidArtery;
    //public GameObject BrachiocephalicArtery;
    //public GameObject LeftSubclavianArtery;
    //public GameObject SuperiorVenaCava;
    //public GameObject Rightpulmonaryartery;
   /// public GameObject InferiorVenaCava;
    public GameObject MitralValve;
    public GameObject TriscuspidValve;
    public GameObject ChordaeTendineaeValve;

    //InsideLabels
    public GameObject LeftAtriumLabel;
    public GameObject RightAtriumLabel;
    public GameObject LeftVentricleLabel;
    public GameObject RightVentricleLabel;
    public GameObject PulmonarySemilunarValveLabel;
    public GameObject LeftPulmonaryVeinsLabel;
    public GameObject LeftPulmonaryArteryLabel;
    public GameObject AortaLabel;
    //public GameObject LeftCommonCarotidArteryLabel;
    //public GameObject BrachiocephalicArteryLabel;
    //public GameObject LeftSubclavianArteryLabel;
    ////public GameObject SuperiorVenaCavaLabel;
    //public GameObject RightpulmonaryarteryLabel;
    //public GameObject InferiorVenaCavaLabel;
    public GameObject MitralValveLabel;
    public GameObject TriscuspidValveLabel;
    public GameObject ChordaeTendineaeValveLabel;

    void OnMouseDown()
    {

        if (gameObject.name == "InsideLeftAtrium")
        {
            FunFacts.SetActive(false);
            LeftAtrium.SetActive(true);
            RightAtrium.SetActive(false);
            LeftVentricle.SetActive(false);
            RightVentricle.SetActive(false);
            PulmonarySemilunarValve.SetActive(false);
            LeftPulmonaryVeins.SetActive(false);
            LeftPulmonaryArtery.SetActive(false);
            Aorta.SetActive(false);
            //LeftCommonCarotidArtery.SetActive(false);
            //BrachiocephalicArtery.SetActive(false);
           // LeftSubclavianArtery.SetActive(false);
            //SuperiorVenaCava.SetActive(false);
            //Rightpulmonaryartery.SetActive(false);
            //InferiorVenaCava.SetActive(false);
            MitralValve.SetActive(false);
            TriscuspidValve.SetActive(false);
            ChordaeTendineaeValve.SetActive(false);

            LeftAtriumLabel.SetActive(true);
            RightAtriumLabel.SetActive(false);
            LeftVentricleLabel.SetActive(false);
            RightVentricleLabel.SetActive(false);
            PulmonarySemilunarValveLabel.SetActive(false);
            LeftPulmonaryVeinsLabel.SetActive(false);
            LeftPulmonaryArteryLabel.SetActive(false);
            AortaLabel.SetActive(false);
            //LeftCommonCarotidArteryLabel.SetActive(false);
            //BrachiocephalicArteryLabel.SetActive(false);
            //LeftSubclavianArteryLabel.SetActive(false);
            //SuperiorVenaCavaLabel.SetActive(false);
           // RightpulmonaryarteryLabel.SetActive(false);
           // InferiorVenaCavaLabel.SetActive(false);
            MitralValveLabel.SetActive(false);
            TriscuspidValveLabel.SetActive(false);
            ChordaeTendineaeValveLabel.SetActive(false);

        }

        if (gameObject.name == "InsideRightAtrium ")
        {
            FunFacts.SetActive(false);
            LeftAtrium.SetActive(false);
            RightAtrium.SetActive(true);
            LeftVentricle.SetActive(false);
            RightVentricle.SetActive(false);
            PulmonarySemilunarValve.SetActive(false);
            LeftPulmonaryVeins.SetActive(false);
            LeftPulmonaryArtery.SetActive(false);
            Aorta.SetActive(false);
           // LeftCommonCarotidArtery.SetActive(false);
            //BrachiocephalicArtery.SetActive(false);
            //LeftSubclavianArtery.SetActive(false);
            //SuperiorVenaCava.SetActive(false);
            //Rightpulmonaryartery.SetActive(false);
           // InferiorVenaCava.SetActive(false);
            MitralValve.SetActive(false);
            TriscuspidValve.SetActive(false);
            ChordaeTendineaeValve.SetActive(false);

            LeftAtriumLabel.SetActive(false);
            RightAtriumLabel.SetActive(true);
            LeftVentricleLabel.SetActive(false);
            RightVentricleLabel.SetActive(false);
            PulmonarySemilunarValveLabel.SetActive(false);
            LeftPulmonaryVeinsLabel.SetActive(false);
            LeftPulmonaryArteryLabel.SetActive(false);
            AortaLabel.SetActive(false);
            //LeftCommonCarotidArteryLabel.SetActive(false);
            //BrachiocephalicArteryLabel.SetActive(false);
            //LeftSubclavianArteryLabel.SetActive(false);
            //SuperiorVenaCavaLabel.SetActive(false);
            //RightpulmonaryarteryLabel.SetActive(false);
           // InferiorVenaCavaLabel.SetActive(false);
            MitralValveLabel.SetActive(false);
            TriscuspidValveLabel.SetActive(false);
            ChordaeTendineaeValveLabel.SetActive(false);

        }
        if (gameObject.name == "InsideLeftVentricle ")
        {
            FunFacts.SetActive(false);
            LeftAtrium.SetActive(false);
            RightAtrium.SetActive(false);
            LeftVentricle.SetActive(true);
            RightVentricle.SetActive(false);
            PulmonarySemilunarValve.SetActive(false);
            LeftPulmonaryVeins.SetActive(false);
            LeftPulmonaryArtery.SetActive(false);
            Aorta.SetActive(false);
           // LeftCommonCarotidArtery.SetActive(false);
            //BrachiocephalicArtery.SetActive(false);
            //LeftSubclavianArtery.SetActive(false);
            //SuperiorVenaCava.SetActive(false);
           // Rightpulmonaryartery.SetActive(false);
           // InferiorVenaCava.SetActive(false);
            MitralValve.SetActive(false);
            TriscuspidValve.SetActive(false);
            ChordaeTendineaeValve.SetActive(false);

            LeftAtriumLabel.SetActive(false);
            RightAtriumLabel.SetActive(false);
            LeftVentricleLabel.SetActive(true);
            RightVentricleLabel.SetActive(false);
            PulmonarySemilunarValveLabel.SetActive(false);
            LeftPulmonaryVeinsLabel.SetActive(false);
            LeftPulmonaryArteryLabel.SetActive(false);
            AortaLabel.SetActive(false);
           // LeftCommonCarotidArteryLabel.SetActive(false);
            //BrachiocephalicArteryLabel.SetActive(false);
           // LeftSubclavianArteryLabel.SetActive(false);
            //SuperiorVenaCavaLabel.SetActive(false);
           // RightpulmonaryarteryLabel.SetActive(false);
            //InferiorVenaCavaLabel.SetActive(false);
            MitralValveLabel.SetActive(false);
            TriscuspidValveLabel.SetActive(false);
            ChordaeTendineaeValveLabel.SetActive(false);

        }

        if (gameObject.name == "InsideRightVentricle ")
        {
            FunFacts.SetActive(false);
            LeftAtrium.SetActive(false);
            RightAtrium.SetActive(false);
            LeftVentricle.SetActive(false);
            RightVentricle.SetActive(true);
            PulmonarySemilunarValve.SetActive(false);
            LeftPulmonaryVeins.SetActive(false);
            LeftPulmonaryArtery.SetActive(false);
            Aorta.SetActive(false);
            //LeftCommonCarotidArtery.SetActive(false);
            //BrachiocephalicArtery.SetActive(false);
           // LeftSubclavianArtery.SetActive(false);
           // SuperiorVenaCava.SetActive(false);
           // Rightpulmonaryartery.SetActive(false);
            //InferiorVenaCava.SetActive(false);
            MitralValve.SetActive(false);
            TriscuspidValve.SetActive(false);
            ChordaeTendineaeValve.SetActive(false);

            LeftAtriumLabel.SetActive(false);
            RightAtriumLabel.SetActive(false);
            LeftVentricleLabel.SetActive(false);
            RightVentricleLabel.SetActive(true);
            PulmonarySemilunarValveLabel.SetActive(false);
            LeftPulmonaryVeinsLabel.SetActive(false);
            LeftPulmonaryArteryLabel.SetActive(false);
            AortaLabel.SetActive(false);
            //LeftCommonCarotidArteryLabel.SetActive(false);
           // BrachiocephalicArteryLabel.SetActive(false);
            //LeftSubclavianArteryLabel.SetActive(false);
            //SuperiorVenaCavaLabel.SetActive(false);
            //RightpulmonaryarteryLabel.SetActive(false);
           // InferiorVenaCavaLabel.SetActive(false);
            MitralValveLabel.SetActive(false);
            TriscuspidValveLabel.SetActive(false);
            ChordaeTendineaeValveLabel.SetActive(false);
        }

        if (gameObject.name == "InsidePulmonarySemilunarValve")
        {
            FunFacts.SetActive(false);
            LeftAtrium.SetActive(false);
            RightAtrium.SetActive(false);
            LeftVentricle.SetActive(false);
            RightVentricle.SetActive(false);
            PulmonarySemilunarValve.SetActive(true);
            LeftPulmonaryVeins.SetActive(false);
            LeftPulmonaryArtery.SetActive(false);
            Aorta.SetActive(false);
           // LeftCommonCarotidArtery.SetActive(false);
            //BrachiocephalicArtery.SetActive(false);
           // LeftSubclavianArtery.SetActive(false);
           // SuperiorVenaCava.SetActive(false);
           // Rightpulmonaryartery.SetActive(false);
           // InferiorVenaCava.SetActive(false);
            MitralValve.SetActive(false);
            TriscuspidValve.SetActive(false);
            ChordaeTendineaeValve.SetActive(false);

            LeftAtriumLabel.SetActive(false);
            RightAtriumLabel.SetActive(false);
            LeftVentricleLabel.SetActive(false);
            RightVentricleLabel.SetActive(false);
            PulmonarySemilunarValveLabel.SetActive(true);
            LeftPulmonaryVeinsLabel.SetActive(false);
            LeftPulmonaryArteryLabel.SetActive(false);
            AortaLabel.SetActive(false);
            //LeftCommonCarotidArteryLabel.SetActive(false);
           // BrachiocephalicArteryLabel.SetActive(false);
           // LeftSubclavianArteryLabel.SetActive(false);
            //SuperiorVenaCavaLabel.SetActive(false);
            //RightpulmonaryarteryLabel.SetActive(false);
           // InferiorVenaCavaLabel.SetActive(false);
            MitralValveLabel.SetActive(false);
            TriscuspidValveLabel.SetActive(false);
            ChordaeTendineaeValveLabel.SetActive(false);
        }

        if (gameObject.name == "InsideLeftPulmonaryVeins ")
        {
            FunFacts.SetActive(false);
            LeftAtrium.SetActive(false);
            RightAtrium.SetActive(false);
            LeftVentricle.SetActive(false);
            RightVentricle.SetActive(false);
            PulmonarySemilunarValve.SetActive(false);
            LeftPulmonaryVeins.SetActive(true);
            LeftPulmonaryArtery.SetActive(false);
            Aorta.SetActive(false);
            //LeftCommonCarotidArtery.SetActive(false);
           // BrachiocephalicArtery.SetActive(false);
           // LeftSubclavianArtery.SetActive(false);
           // SuperiorVenaCava.SetActive(false);
           // Rightpulmonaryartery.SetActive(false);
          //  InferiorVenaCava.SetActive(false);
            MitralValve.SetActive(false);
            TriscuspidValve.SetActive(false);
            ChordaeTendineaeValve.SetActive(false);

            LeftAtriumLabel.SetActive(false);
            RightAtriumLabel.SetActive(false);
            LeftVentricleLabel.SetActive(false);
            RightVentricleLabel.SetActive(false);
            PulmonarySemilunarValveLabel.SetActive(false);
            LeftPulmonaryVeinsLabel.SetActive(true);
            LeftPulmonaryArteryLabel.SetActive(false);
            AortaLabel.SetActive(false);
           // LeftCommonCarotidArteryLabel.SetActive(false);
           // BrachiocephalicArteryLabel.SetActive(false);
           // LeftSubclavianArteryLabel.SetActive(false);
           // SuperiorVenaCavaLabel.SetActive(false);
           // RightpulmonaryarteryLabel.SetActive(false);
           // InferiorVenaCavaLabel.SetActive(false);
            MitralValveLabel.SetActive(false);
            TriscuspidValveLabel.SetActive(false);
            ChordaeTendineaeValveLabel.SetActive(false);
        }
        if (gameObject.name == "InsideLeftPulmonaryArtery ")
        {
            FunFacts.SetActive(false);
            LeftAtrium.SetActive(false);
            RightAtrium.SetActive(false);
            LeftVentricle.SetActive(false);
            RightVentricle.SetActive(false);
            PulmonarySemilunarValve.SetActive(false);
            LeftPulmonaryVeins.SetActive(false);
            LeftPulmonaryArtery.SetActive(true);
            Aorta.SetActive(false);
           // LeftCommonCarotidArtery.SetActive(false);
            //BrachiocephalicArtery.SetActive(false);
           // LeftSubclavianArtery.SetActive(false);
           // SuperiorVenaCava.SetActive(false);
           // Rightpulmonaryartery.SetActive(false);
           // InferiorVenaCava.SetActive(false);
            MitralValve.SetActive(false);
            TriscuspidValve.SetActive(false);
            ChordaeTendineaeValve.SetActive(false);

            LeftAtriumLabel.SetActive(false);
            RightAtriumLabel.SetActive(false);
            LeftVentricleLabel.SetActive(false);
            RightVentricleLabel.SetActive(false);
            PulmonarySemilunarValveLabel.SetActive(false);
            LeftPulmonaryVeinsLabel.SetActive(false);
            LeftPulmonaryArteryLabel.SetActive(true);
            AortaLabel.SetActive(false);
           // LeftCommonCarotidArteryLabel.SetActive(false);
           // BrachiocephalicArteryLabel.SetActive(false);
            //LeftSubclavianArteryLabel.SetActive(false);
            //SuperiorVenaCavaLabel.SetActive(false);
            //RightpulmonaryarteryLabel.SetActive(false);
            //InferiorVenaCavaLabel.SetActive(false);
            MitralValveLabel.SetActive(false);
            TriscuspidValveLabel.SetActive(false);
            ChordaeTendineaeValveLabel.SetActive(false);
        }

        if (gameObject.name == "OutsideAorticarch")
        {
            FunFacts.SetActive(false);
            LeftAtrium.SetActive(false);
            RightAtrium.SetActive(false);
            LeftVentricle.SetActive(false);
            RightVentricle.SetActive(false);
            PulmonarySemilunarValve.SetActive(false);
            LeftPulmonaryVeins.SetActive(false);
            LeftPulmonaryArtery.SetActive(false);
            Aorta.SetActive(true);
           // LeftCommonCarotidArtery.SetActive(false);
            //BrachiocephalicArtery.SetActive(false);
           // LeftSubclavianArtery.SetActive(false);
           // SuperiorVenaCava.SetActive(false);
            //Rightpulmonaryartery.SetActive(false);
            //InferiorVenaCava.SetActive(false);
            MitralValve.SetActive(false);
            TriscuspidValve.SetActive(false);
            ChordaeTendineaeValve.SetActive(false);

            LeftAtriumLabel.SetActive(false);
            RightAtriumLabel.SetActive(false);
            LeftVentricleLabel.SetActive(false);
            RightVentricleLabel.SetActive(false);
            PulmonarySemilunarValveLabel.SetActive(false);
            LeftPulmonaryVeinsLabel.SetActive(false);
            LeftPulmonaryArteryLabel.SetActive(false);
            AortaLabel.SetActive(true);
            //LeftCommonCarotidArteryLabel.SetActive(false);
           // BrachiocephalicArteryLabel.SetActive(false);
           // LeftSubclavianArteryLabel.SetActive(false);
           // RightpulmonaryarteryLabel.SetActive(false);
            //InferiorVenaCavaLabel.SetActive(false);
            MitralValveLabel.SetActive(false);
            TriscuspidValveLabel.SetActive(false);
            ChordaeTendineaeValveLabel.SetActive(false);
        }

        if (gameObject.name == "InsideLeftCommonCarotidArtery")
        {
            FunFacts.SetActive(false);
            LeftAtrium.SetActive(false);
            RightAtrium.SetActive(false);
            LeftVentricle.SetActive(false);
            RightVentricle.SetActive(false);
            PulmonarySemilunarValve.SetActive(false);
            LeftPulmonaryVeins.SetActive(false);
            LeftPulmonaryArtery.SetActive(false);
            Aorta.SetActive(false);
            //LeftCommonCarotidArtery.SetActive(true);
            //BrachiocephalicArtery.SetActive(false);
            //LeftSubclavianArtery.SetActive(false);
            //SuperiorVenaCava.SetActive(false);
            //Rightpulmonaryartery.SetActive(false);
            //InferiorVenaCava.SetActive(false);
            MitralValve.SetActive(false);
            TriscuspidValve.SetActive(false);
            ChordaeTendineaeValve.SetActive(false);

            LeftAtriumLabel.SetActive(false);
            RightAtriumLabel.SetActive(false);
            LeftVentricleLabel.SetActive(false);
            RightVentricleLabel.SetActive(false);
            PulmonarySemilunarValveLabel.SetActive(false);
            LeftPulmonaryVeinsLabel.SetActive(false);
            LeftPulmonaryArteryLabel.SetActive(false);
            AortaLabel.SetActive(false);
            //LeftCommonCarotidArteryLabel.SetActive(true);
            //BrachiocephalicArteryLabel.SetActive(false);
            //LeftSubclavianArteryLabel.SetActive(false);
            //SuperiorVenaCavaLabel.SetActive(false);
            //RightpulmonaryarteryLabel.SetActive(false);
            //InferiorVenaCavaLabel.SetActive(false);
            MitralValveLabel.SetActive(false);
            TriscuspidValveLabel.SetActive(false);
            ChordaeTendineaeValveLabel.SetActive(false);
        }

        if (gameObject.name == "InsideBrachiocephalicArtery")
        {
            FunFacts.SetActive(false);
            LeftAtrium.SetActive(false);
            RightAtrium.SetActive(false);
            LeftVentricle.SetActive(false);
            RightVentricle.SetActive(false);
            PulmonarySemilunarValve.SetActive(false);
            LeftPulmonaryVeins.SetActive(false);
            LeftPulmonaryArtery.SetActive(false);
            Aorta.SetActive(false);
            //LeftCommonCarotidArtery.SetActive(false);
            //BrachiocephalicArtery.SetActive(true);
            //LeftSubclavianArtery.SetActive(false);
            //SuperiorVenaCava.SetActive(false);
            //Rightpulmonaryartery.SetActive(false);
            //InferiorVenaCava.SetActive(false);
            MitralValve.SetActive(false);
            TriscuspidValve.SetActive(false);
            ChordaeTendineaeValve.SetActive(false);

            LeftAtriumLabel.SetActive(false);
            RightAtriumLabel.SetActive(false);
            LeftVentricleLabel.SetActive(false);
            RightVentricleLabel.SetActive(false);
            PulmonarySemilunarValveLabel.SetActive(false);
            LeftPulmonaryVeinsLabel.SetActive(false);
            LeftPulmonaryArteryLabel.SetActive(false);
            AortaLabel.SetActive(false);
            //LeftCommonCarotidArteryLabel.SetActive(false);
            //BrachiocephalicArteryLabel.SetActive(true);
            //LeftSubclavianArteryLabel.SetActive(false);
            //SuperiorVenaCavaLabel.SetActive(false);
            //RightpulmonaryarteryLabel.SetActive(false);
            //InferiorVenaCavaLabel.SetActive(false);
            MitralValveLabel.SetActive(false);
            TriscuspidValveLabel.SetActive(false);
            ChordaeTendineaeValveLabel.SetActive(false);


        }

        if (gameObject.name == "InsideLeftSubclavianArtery")
        {
            FunFacts.SetActive(false);
            LeftAtrium.SetActive(false);
            RightAtrium.SetActive(false);
            LeftVentricle.SetActive(false);
            RightVentricle.SetActive(false);
            PulmonarySemilunarValve.SetActive(false);
            LeftPulmonaryVeins.SetActive(false);
            LeftPulmonaryArtery.SetActive(false);
            Aorta.SetActive(false);
            //LeftCommonCarotidArtery.SetActive(false);
            //BrachiocephalicArtery.SetActive(false);
            //LeftSubclavianArtery.SetActive(true);
            //SuperiorVenaCava.SetActive(false);
            //Rightpulmonaryartery.SetActive(false);
            //InferiorVenaCava.SetActive(false);
            MitralValve.SetActive(false);
            TriscuspidValve.SetActive(false);
            ChordaeTendineaeValve.SetActive(false);

            LeftAtriumLabel.SetActive(false);
            RightAtriumLabel.SetActive(false);
            LeftVentricleLabel.SetActive(false);
            RightVentricleLabel.SetActive(false);
            PulmonarySemilunarValveLabel.SetActive(false);
            LeftPulmonaryVeinsLabel.SetActive(false);
            LeftPulmonaryArteryLabel.SetActive(false);
            AortaLabel.SetActive(false);
            //LeftCommonCarotidArteryLabel.SetActive(false);
            //BrachiocephalicArteryLabel.SetActive(false);
            //LeftSubclavianArteryLabel.SetActive(true);
            //SuperiorVenaCavaLabel.SetActive(false);
            //RightpulmonaryarteryLabel.SetActive(false);
            //InferiorVenaCavaLabel.SetActive(false);
            MitralValveLabel.SetActive(false);
            TriscuspidValveLabel.SetActive(false);
            ChordaeTendineaeValveLabel.SetActive(false);

        }

        if (gameObject.name == "InsideSuperiorVenaCava")
        {
            FunFacts.SetActive(false);
            LeftAtrium.SetActive(false);
            RightAtrium.SetActive(false);
            LeftVentricle.SetActive(false);
            RightVentricle.SetActive(false);
            PulmonarySemilunarValve.SetActive(false);
            LeftPulmonaryVeins.SetActive(false);
            LeftPulmonaryArtery.SetActive(false);
            Aorta.SetActive(false);
            //LeftCommonCarotidArtery.SetActive(false);
            //BrachiocephalicArtery.SetActive(false);
            //LeftSubclavianArtery.SetActive(false);
            //SuperiorVenaCava.SetActive(true);
            //Rightpulmonaryartery.SetActive(false);
            //InferiorVenaCava.SetActive(false);
            MitralValve.SetActive(false);
            TriscuspidValve.SetActive(false);
            ChordaeTendineaeValve.SetActive(false);

            LeftAtriumLabel.SetActive(false);
            RightAtriumLabel.SetActive(false);
            LeftVentricleLabel.SetActive(false);
            RightVentricleLabel.SetActive(false);
            PulmonarySemilunarValveLabel.SetActive(false);
            LeftPulmonaryVeinsLabel.SetActive(false);
            LeftPulmonaryArteryLabel.SetActive(false);
            AortaLabel.SetActive(false);
            //LeftCommonCarotidArteryLabel.SetActive(false);
            //BrachiocephalicArteryLabel.SetActive(false);
            //LeftSubclavianArteryLabel.SetActive(false);
            //SuperiorVenaCavaLabel.SetActive(true);
            //RightpulmonaryarteryLabel.SetActive(false);
            //InferiorVenaCavaLabel.SetActive(false);
            MitralValveLabel.SetActive(false);
            TriscuspidValveLabel.SetActive(false);
            ChordaeTendineaeValveLabel.SetActive(false);

        }
        if (gameObject.name == "InsideRightpulmonaryartery")
        {
            FunFacts.SetActive(false);
            LeftAtrium.SetActive(false);
            RightAtrium.SetActive(false);
            LeftVentricle.SetActive(false);
            RightVentricle.SetActive(false);
            PulmonarySemilunarValve.SetActive(false);
            LeftPulmonaryVeins.SetActive(false);
            LeftPulmonaryArtery.SetActive(false);
            Aorta.SetActive(false);
            //LeftCommonCarotidArtery.SetActive(false);
            //BrachiocephalicArtery.SetActive(false);
            //LeftSubclavianArtery.SetActive(false);
            //SuperiorVenaCava.SetActive(false);
            //Rightpulmonaryartery.SetActive(true);
            //InferiorVenaCava.SetActive(false);
            MitralValve.SetActive(false);
            TriscuspidValve.SetActive(false);
            ChordaeTendineaeValve.SetActive(false);

            LeftAtriumLabel.SetActive(false);
            RightAtriumLabel.SetActive(false);
            LeftVentricleLabel.SetActive(false);
            RightVentricleLabel.SetActive(false);
            PulmonarySemilunarValveLabel.SetActive(false);
            LeftPulmonaryVeinsLabel.SetActive(false);
            LeftPulmonaryArteryLabel.SetActive(false);
            AortaLabel.SetActive(false);
            //LeftCommonCarotidArteryLabel.SetActive(false);
            //BrachiocephalicArteryLabel.SetActive(false);
            //LeftSubclavianArteryLabel.SetActive(false);
            //SuperiorVenaCavaLabel.SetActive(false);
            //RightpulmonaryarteryLabel.SetActive(true);
            //InferiorVenaCavaLabel.SetActive(false);
            MitralValveLabel.SetActive(false);
            TriscuspidValveLabel.SetActive(false);
            ChordaeTendineaeValveLabel.SetActive(false);

        }


        if (gameObject.name == "InsideInferiorVenaCava")
        {
            FunFacts.SetActive(false);
            LeftAtrium.SetActive(false);
            RightAtrium.SetActive(false);
            LeftVentricle.SetActive(false);
            RightVentricle.SetActive(false);
            PulmonarySemilunarValve.SetActive(false);
            LeftPulmonaryVeins.SetActive(false);
            LeftPulmonaryArtery.SetActive(false);
            Aorta.SetActive(false);
            //LeftCommonCarotidArtery.SetActive(false);
            //BrachiocephalicArtery.SetActive(false);
            //LeftSubclavianArtery.SetActive(false);
            //SuperiorVenaCava.SetActive(false);
            //Rightpulmonaryartery.SetActive(false);
            //InferiorVenaCava.SetActive(true);
            MitralValve.SetActive(false);
            TriscuspidValve.SetActive(false);
            ChordaeTendineaeValve.SetActive(false);

            LeftAtriumLabel.SetActive(false);
            RightAtriumLabel.SetActive(false);
            LeftVentricleLabel.SetActive(false);
            RightVentricleLabel.SetActive(false);
            PulmonarySemilunarValveLabel.SetActive(false);
            LeftPulmonaryVeinsLabel.SetActive(false);
            LeftPulmonaryArteryLabel.SetActive(false);
            AortaLabel.SetActive(false);
            //LeftCommonCarotidArteryLabel.SetActive(false);
            //BrachiocephalicArteryLabel.SetActive(false);
            //LeftSubclavianArteryLabel.SetActive(false);
            //SuperiorVenaCavaLabel.SetActive(false);
            //RightpulmonaryarteryLabel.SetActive(false);
           // InferiorVenaCavaLabel.SetActive(true);
            MitralValveLabel.SetActive(false);
            TriscuspidValveLabel.SetActive(false);
            ChordaeTendineaeValveLabel.SetActive(false);

        }

        if (gameObject.name == "InsideMitralValve")
        {
            FunFacts.SetActive(false);
            LeftAtrium.SetActive(false);
            RightAtrium.SetActive(false);
            LeftVentricle.SetActive(false);
            RightVentricle.SetActive(false);
            PulmonarySemilunarValve.SetActive(false);
            LeftPulmonaryVeins.SetActive(false);
            LeftPulmonaryArtery.SetActive(false);
            Aorta.SetActive(false);
            //LeftCommonCarotidArtery.SetActive(false);
            //BrachiocephalicArtery.SetActive(false);
            //LeftSubclavianArtery.SetActive(false);
            //SuperiorVenaCava.SetActive(false);
            //Rightpulmonaryartery.SetActive(false);
            //InferiorVenaCava.SetActive(false);
            MitralValve.SetActive(true);
            TriscuspidValve.SetActive(false);
            ChordaeTendineaeValve.SetActive(false);

            LeftAtriumLabel.SetActive(false);
            RightAtriumLabel.SetActive(false);
            LeftVentricleLabel.SetActive(false);
            RightVentricleLabel.SetActive(false);
            PulmonarySemilunarValveLabel.SetActive(false);
            LeftPulmonaryVeinsLabel.SetActive(false);
            LeftPulmonaryArteryLabel.SetActive(false);
            AortaLabel.SetActive(false);
            //LeftCommonCarotidArteryLabel.SetActive(false);
            //BrachiocephalicArteryLabel.SetActive(false);
            //LeftSubclavianArteryLabel.SetActive(false);
            //SuperiorVenaCavaLabel.SetActive(false);
            //RightpulmonaryarteryLabel.SetActive(false);
            //InferiorVenaCavaLabel.SetActive(false);
            MitralValveLabel.SetActive(true);
            TriscuspidValveLabel.SetActive(false);
            ChordaeTendineaeValveLabel.SetActive(false);

        }
        if (gameObject.name == "InsideTriscuspidValve")
        {
            FunFacts.SetActive(false);
            LeftAtrium.SetActive(false);
            RightAtrium.SetActive(false);
            LeftVentricle.SetActive(false);
            RightVentricle.SetActive(false);
            PulmonarySemilunarValve.SetActive(false);
            LeftPulmonaryVeins.SetActive(false);
            LeftPulmonaryArtery.SetActive(false);
            Aorta.SetActive(false);
            //LeftCommonCarotidArtery.SetActive(false);
            //BrachiocephalicArtery.SetActive(false);
            //LeftSubclavianArtery.SetActive(false);
            //SuperiorVenaCava.SetActive(false);
            //Rightpulmonaryartery.SetActive(false);
            //InferiorVenaCava.SetActive(false);
            MitralValve.SetActive(false);
            TriscuspidValve.SetActive(true);
            ChordaeTendineaeValve.SetActive(false);

            LeftAtriumLabel.SetActive(false);
            RightAtriumLabel.SetActive(false);
            LeftVentricleLabel.SetActive(false);
            RightVentricleLabel.SetActive(false);
            PulmonarySemilunarValveLabel.SetActive(false);
            LeftPulmonaryVeinsLabel.SetActive(false);
            LeftPulmonaryArteryLabel.SetActive(false);
            AortaLabel.SetActive(false);
            //LeftCommonCarotidArteryLabel.SetActive(false);
            //BrachiocephalicArteryLabel.SetActive(false);
            //LeftSubclavianArteryLabel.SetActive(false);
            //SuperiorVenaCavaLabel.SetActive(false);
            //RightpulmonaryarteryLabel.SetActive(false);
            //InferiorVenaCavaLabel.SetActive(false);
            MitralValveLabel.SetActive(false);
            TriscuspidValveLabel.SetActive(true);
            ChordaeTendineaeValveLabel.SetActive(false);

        }

        if (gameObject.name == "InsideChordaeTendineae")
        {
            FunFacts.SetActive(false);
            LeftAtrium.SetActive(false);
            RightAtrium.SetActive(false);
            LeftVentricle.SetActive(false);
            RightVentricle.SetActive(false);
            PulmonarySemilunarValve.SetActive(false);
            LeftPulmonaryVeins.SetActive(false);
            LeftPulmonaryArtery.SetActive(false);
            Aorta.SetActive(false);
            //LeftCommonCarotidArtery.SetActive(false);
            //BrachiocephalicArtery.SetActive(false);
            //LeftSubclavianArtery.SetActive(false);
            //SuperiorVenaCava.SetActive(false);
            //Rightpulmonaryartery.SetActive(false);
            //InferiorVenaCava.SetActive(false);
            MitralValve.SetActive(false);
            TriscuspidValve.SetActive(false);
            ChordaeTendineaeValve.SetActive(true);

            LeftAtriumLabel.SetActive(false);
            RightAtriumLabel.SetActive(false);
            LeftVentricleLabel.SetActive(false);
            RightVentricleLabel.SetActive(false);
            PulmonarySemilunarValveLabel.SetActive(false);
            LeftPulmonaryVeinsLabel.SetActive(false);
            LeftPulmonaryArteryLabel.SetActive(false);
            AortaLabel.SetActive(false);
            //LeftCommonCarotidArteryLabel.SetActive(false);
            //BrachiocephalicArteryLabel.SetActive(false);
            //LeftSubclavianArteryLabel.SetActive(false);
            //SuperiorVenaCavaLabel.SetActive(false);
            //RightpulmonaryarteryLabel.SetActive(false);
            //InferiorVenaCavaLabel.SetActive(false);
            MitralValveLabel.SetActive(false);
            TriscuspidValveLabel.SetActive(false);
            ChordaeTendineaeValveLabel.SetActive(true);
        }

        if (gameObject.name == "InsideAorta")
        {
            FunFacts.SetActive(false);
            LeftAtrium.SetActive(false);
            RightAtrium.SetActive(false);
            LeftVentricle.SetActive(false);
            RightVentricle.SetActive(false);
            PulmonarySemilunarValve.SetActive(false);
            LeftPulmonaryVeins.SetActive(false);
            LeftPulmonaryArtery.SetActive(false);
            Aorta.SetActive(true);
            //LeftCommonCarotidArtery.SetActive(false);
            //BrachiocephalicArtery.SetActive(false);
            //LeftSubclavianArtery.SetActive(false);
            //SuperiorVenaCava.SetActive(false);
            //Rightpulmonaryartery.SetActive(false);
            //InferiorVenaCava.SetActive(false);
            MitralValve.SetActive(false);
            TriscuspidValve.SetActive(false);
            ChordaeTendineaeValve.SetActive(false);

            LeftAtriumLabel.SetActive(false);
            RightAtriumLabel.SetActive(false);
            LeftVentricleLabel.SetActive(false);
            RightVentricleLabel.SetActive(false);
            PulmonarySemilunarValveLabel.SetActive(false);
            LeftPulmonaryVeinsLabel.SetActive(false);
            LeftPulmonaryArteryLabel.SetActive(false);
            AortaLabel.SetActive(true);
            //LeftCommonCarotidArteryLabel.SetActive(false);
            //BrachiocephalicArteryLabel.SetActive(false);
            //LeftSubclavianArteryLabel.SetActive(false);
            //SuperiorVenaCavaLabel.SetActive(false);
            //RightpulmonaryarteryLabel.SetActive(false);
            //InferiorVenaCavaLabel.SetActive(false);
            MitralValveLabel.SetActive(false);
            TriscuspidValveLabel.SetActive(false);
            ChordaeTendineaeValveLabel.SetActive(false);
        }

    }
}
