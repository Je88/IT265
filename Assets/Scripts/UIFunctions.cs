using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class UIFunctions : MonoBehaviour
{
    [Header("Title Scene Properties", order = 0)]
    [Space(2f)]
    [Header("Intro Scene Properties", order = 1)]
    public GameObject introImage;
    public GameObject backButton;
    public GameObject nextButton;
    public Color backgroundColor;
    public TMP_Text introText;
    [Header("Tutorial Scene Properties", order = 2)]
    [Space(2f)]
    [Header("Level01 Scene Properties", order = 3)]

    int introSequence;
    Scene currentScene;

	public void SetScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
	
	private void Awake()
    {
        currentScene = SceneManager.GetActiveScene();
        switch (currentScene.name)
        {
            case "00TitleScene":
                break;
            case "01IntroScene":
                introText.text = "Welcome to Coral Corral\n\n" +
				"Learn about Coral and You!\n\n\n\n";
				introImage.SetActive(true);
				backButton.SetActive(false);
                break;
            case "02TutorialScene":
                break;
            case "03LV01Scene":
                break;
        }
    }
	
	void InitializeIntro()
    {
        introText.horizontalAlignment = HorizontalAlignmentOptions.Center;
        introText.text = "Welcome to Bubble Sort in 3D!\n\n" +
            "Learn computer science principles by interacting with 3D objects!\n\n\n\n";
        introImage.SetActive(true);
        backButton.SetActive(false);
    }
	
	
	 public void IntroSequenceBack()
    {
        introSequence--;
        SetIntroSequence();
    }

    public void IntroSequenceNext()
    {
        introSequence++;
        SetIntroSequence();
    }

    void SetIntroSequence()
    {
        switch (introSequence)
        {
            case 0:
                InitializeIntro();
                break;
            case 1:
                introImage.SetActive(false);
                backButton.SetActive(true);
                introText.horizontalAlignment = HorizontalAlignmentOptions.Left;
                introText.text = "OVERVIEW\n\n" +
                    "Title: Coral Corral\n" +
                    "Platform: WebGL build\n" +
                    "Subject: Biology\n" +
                    "Sub Subject: Marine Biology\n" +
                    "Main Focus: Coral Reef \n" +
                    "Learning Level: Grades 6-9";
                break;
            case 2:
                introText.text = "PROPOSED EDTECH SOLUTION\n\n" +
                    "Students in urban environments may find it difficult to relate to the issues found closer to the coast. To establish that connection I propose we develop an interactive simulation where students interact with a representation of the major coral reefs and present the issues that are plaguing them to the point of extinction. To show how their actions can counteract that of lesser informed people and predators present.";
                break;
            case 3:
                introText.text = "COMPETING SOFTWARE REVIEW\n\n" +
                    "David Attenborough’s Great Barrier Reef - PC Slideshow that presents the player with everything from the wildlife that call the reef home to the threats it encounters and all this in the major reefs around the world.\n\n" +
                    "MullenLowe's ocean clean-up - PC game, whose purpose is to show what does not belong in the ocean through a fun and interactive game where you play as an octopus and crab duo collecting trash and cleaning up the ocean below.\n\n" +
                    "Invaders!|PLUM LANDING - PC game, that teaches about invasive species both intentionally and not intentionally introduced to the environment. It is a still page game where users are presented the native species and bubble out the invasive animals to keep a thriving ecosystem.";
                break;
            case 4:
                introText.text = "COMPETING SOFTWARE SUGGESTED IMPROVEMENTS\n\n" +
                    "Gameplay and immersion - AR/VR interactives to aid the player so they can experience wildlife on a more personal level.\n\n" +
                    "Engagement factors​ - more wildlife along with tracker that shows the effects the player has on the environment.\n\n" +
                    "Better accessibility​ - Ability for users to access the application from multiple devices and not just at a desktop computer. ";
                break;
            case 5:
                introText.text = "STAKEHOLDERS & USERS\n\n" +
                    "Teachers / Parents / Students\n" +
                    "Users:  ​Middle school students upwards of intro biology in highschool ";
                break;
            case 6:
                introText.text = "PERSONA\n\n" +
                    "Name: Daenerys\n" +
                    "Age: 13 years old\n" +
                    "Gender: Female\n" +
                    "Location: Newark, NJ\n" +
                    "Personal Notes:\n" +
                    "     Keeps up with current technology trends\n" +
                    "     On her phone / laptop majority of the day\n" +
					"     Churros are her favorite dessert\n" +
                    "Students Notes:\n" +
                    "     Doesn’t understand why certain marine life/coral reefs are off limits\n" +
                    "     Doesn't learn well from lecture and memorization\n" +
                    "     A hands on learner and doesn't mind getting her hands dirty\n" +
                    "     Interested in marine biology and wants to better understand it's inhabitants";
                break;
            case 7:
                introText.text = "PERSONA JUSTIFICATION\n\n" +
                    "Our persona represents the users of this educational application; a middle school student who is fraught with questions but could not find an easily digestible and interactive solution. I chose this age range for the persona because middle and high school is when students start to focus on interests which could lead to forming a foundation for what they might study going forward.\n\n";
                break;
            case 8:
                introText.text = "PROBLEM SCENARIO\n\n" +
                    "Going into highschool Daenerys was hoping that her questions from middle school would be answered in a manner with a twist. Especially when it comes to the coral reef she wished to know what she could do.\n\n" +
                    "Daenerys is new to the school and is looking forward to her biology class specifically the marine portion that will be covered the first half of the semester. SHes engrossed in the lecture and sees this as an opportunity to break out of her shell and express her interest before they move on to the next topic. A week has passed and the class hasn’t melded quite as well as the professor hoped but he is aware of Daenerys’ passion for the topic and decides to try something different to get the material across and bring the class together.";
                break;
            case 9:
                introText.text = "ACTIVITY SCENARIO\n\n" +
                    "The next class Daenerys’ Astronomy teacher tells the class that they will go to the lab and cover the coral reef with all its predators and how we could recover it through an interactive scuba diving simulation using VR and the class erupts in excitement.";
                break;
            case 10:
                nextButton.SetActive(true);
                introText.text = "ACTIVITY SCENARIO CONTINUED\n\n" +
                    "After playing the simulation for a few classes, her understanding of coral was exponential as opposed to what she retained from the lectures. The virtual 3D models of coral helped her understand the scale and gravity of the situation. Using VR joysticks to swim up to the different kinds of coral and cycle through the treatments in her pack the first hand experience imprinted the knowledge on her from then on. Fueling her and pushing her to look further into marine biology.";
                break;
            case 11:
                nextButton.SetActive(false);
                introText.text = "PROBLEM STATEMENT\n\n" +
                    "Daenerys wants to use her interest in biology to get along better with her classmates through marine biology. She learns and understands more of the topic using interactive scuba diving simulation in VR.  ";
                break;
        }
    }
}
