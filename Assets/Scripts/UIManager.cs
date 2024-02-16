using System.Net.Http.Headers;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] TMP_Text PlaqueText;
    [SerializeField] GameObject ContentCanvas;
    [SerializeField] TMP_Text ContentHeaderText;
    [SerializeField] TMP_Text ContentBodyText;
    void Start()
    {
        HandleGameStateChanged(GameManager.Instance.State);
        GameManager.OnGameStateChanged += HandleGameStateChanged;
    }
    void OnDestroy()
    {
        GameManager.OnGameStateChanged -= HandleGameStateChanged;
    }

    public void ToggleContent()
    {
        if (ContentCanvas.activeSelf)
        {
            ContentCanvas.SetActive(false);
        }
        else ContentCanvas.SetActive(true);
    }

    private void HandleGameStateChanged(GameState state)
    {
        switch (state)
        {
            case GameState.Cup:
                UpdateName("Menstrual Cup");
                ContentBodyText.text = CupContent;
                break;
            case GameState.Liner:
                UpdateName("Panty Liner");
                ContentBodyText.text = LinerContent;
                break;
            case GameState.Pad:
                UpdateName("Menstrual Pad");
                ContentBodyText.text = PadContent;
                break;
            case GameState.Disc:
                UpdateName("Menstrual Disc");
                ContentBodyText.text = DiscContent;
                break;
            case GameState.Tampon:
                UpdateName("Tampon");
                ContentBodyText.text = TamponContent;
                break;
            default:
                break;
        }
    }

    private void UpdateName(string name)
    {
        PlaqueText.text = name;
        ContentHeaderText.text = name;
    }

    private const string CupContent = "<size=19><b><sprite=5> How to Use:</b> Menstrual cups are small, flexible cups that collect blood inside your vagina. They usually come in a small or large size. If you have a light to medium flow, are under 30 years old, or haven’t given birth vaginally, try out the small size. If you are older than 30, have a heavy flow, or have delivered vaginally, opt for the larger size.<br><br>To get started, wash your hands with soap and wet the cup with water. Fold the rim of the cup in half like a taco. Use your dominant hand to hold the folded cup and the other to spread apart your labia, the outer lips of your private area. Insert the cup, rim side up, at a slight angle back. Once the cup is inside, it will pop open to its original shape and create a seal to prevent leaks. If it doesn’t pop open, rotate the cup until it does. If inserted properly, you shouldn’t be able to feel the cup when you move, and it should be comfortable.<b><br><br><sprite=0> Coverage:</b> 6-12 hours depending on flow. <b><br><br><sprite=3> How to Remove:</b> Wash your hands with soap. Find the base of the cup, right above the stem, with your fingers. Pinch the base to break the seal and pull the cup down, being careful to keep it upright to prevent spills. Once removed, dump the contents in the toilet and wash the cup with soap and water. At the end of your cycle, sanitize the cup by placing it in boiling water for 1-2 minutes. <b><br><br><sprite=1> Cost:</b> $13 to $25 and can last up to 10 years.<b><br><br><sprite=4> Sustainability:</b> Menstrual cups have the lowest environmental footprint because they are made from rubber or silicone that lasts for many years.<b><br><br><sprite=2> Bonus Points:</b> Menstrual cups are a great option to use when playing sports or swimming because they collect blood inside rather than outside your body and won’t move around. They need to be changed less often than tampons and can stay in overnight. Because cups are reusable, they are convenient, cost effective, and sustainable.\r\n";
    private const string TamponContent = "<size=19><b><sprite=5> How to Use:</b> Tampons contain a small, cylindrical piece of fabric that is meant to stay inside your vagina and absorb blood. Many tampons come with plastic or cardboard applicators, though some do not. To get started, wash your hands with soap and unwrap the plastic packaging. <br><br>If your tampon has an applicator, hold it with your dominant hand and use the other hand to spread apart your labia, or the outer lips of your private area. Insert the applicator to its base into the vagina at a slight back angle, then push the smaller tube all the way in. Remove the applicator and put it in the trash.<br><br>If your tampon does not have an applicator, hold it at the base with your dominant hand and make sure the string is hanging loose. Use your other hand to spread apart your labia, or the outer lips of your private area, and locate the entrance of your vagina. Insert the tampon and use your pointer finger to push it into a comfortable position. <br><br>If the tampon is uncomfortable, it may not be inserted far enough, and you can nudge it up slightly with your finger. Make sure the string is hanging outside your vagina. <b><br><br><sprite=0> Coverage:</b> Tampons come in a few different sizes: lite, regular/normal, super, and super plus. The size refers to the tampon’s absorbency, or how much blood it can soak up. At the beginning or end of your period, when flow is lighter, opt for a lite or regular/normal size. Use the super or super plus sizes on heavy-flow days. If you notice a tampon is saturated with blood or leaking after a short amount of time, go up in size. If a tampon is still white and unsaturated when removed, go down in size. Tampons should be changed every 4-6 hours.<b><br><br><sprite=3> How to Remove:</b> To remove a tampon, tug on the string until it comes out completely, then wrap it in toilet paper and put it in the trash.<b><br><br><sprite=1> Cost:</b> $7 per box at an average of 9 boxes per year = $63 per year.<b><br><br><sprite=4> Sustainability:</b> To lower the environmental footprint of tampons, opt for ones with no plastic applicator. For a zero-waste option, consider switching to reusable products like a menstrual cup.<b><br><br><sprite=2> Bonus Points:</b> Tampons are discreet, small enough to fit in a pocket, and easier to use than menstrual cups or discs. Because they absorb blood inside your body with only a piece of string hanging out, tampons are great to wear when swimming or playing sports.";
    private const string LinerContent = "<size=19><b><sprite=5> How to Use:</b> Panty liners are thin pieces of absorbent fabric that stick to the inside of your underwear. Unlike menstrual pads, they are meant to be used only for very light flows or in combination with other menstrual products, like tampons, cups, or discs. To use a liner, simply remove its packing and the adhesive strip of paper from the back. Then stick the liner to your underwear. For a reusable option, consider trying period underwear, which has built in absorbent material.<b><br><br><sprite=0> Coverage:</b> 3-4 hours.<b><br><br><sprite=3> How to Remove:</b> To remove, unstick the liner, wrap in toilet paper, and put in the trash. If using period underwear, rinse in cold water until the water runs clear, then wash with soap and cold water by hand or in a laundry machine.<b><br><br><sprite=1> Cost:</b> Panty liners are usually very cheap and sold in bulk, at around 7 cents a liner. Period underwear costs $24 to $65 per pair.<b><br><br><sprite=4> Sustainability:</b> Panty liners typically have less plastic packaging and waste than menstrual pads, but they are still a disposable product. To lower the environmental footprint of liners, opt for period underwear, which is reusable.<b><br><br><sprite=2> Bonus Points:</b> Panty liners are a great back-up option. They can be used before or after a period, when you might have spotting, or in combination with other products. For example, you can wear a panty liner in addition to a tampon to ensure that no leaks will stain your underwear.";
    private const string DiscContent = "<size=19><b><sprite=5> How to Use:</b> Menstrual discs are shallow, round cups that sit at the base of the cervix and collect blood. Unlike menstrual cups, that use suction to stay in place in the vaginal canal, menstrual discs are pushed farther back and tucked behind the pubic bone, which holds them in place.<b><br><br><sprite=0> Coverage:</b> Up to 12 hours, depending on flow.<b><br><br><sprite=3> How to Remove:</b> First, wash your hands with soap. Slide a finger up the vagina until you feel the disc. Hook your finger over the rim and slowly pull the disc out. Be careful to keep the disc level to prevent it spilling. Once removed, empty the contents into the toilet. If using a disposable disc, wrap it in toilet paper and put it in the trash. If using a reusable disc, wash with soap and water.<b><br><br><sprite=1> Cost:</b> Depending on the brand, disposable menstrual discs cost $10 to $20 per pack, which costs an average of $144 per year. Reusable discs cost an estimated $17 to $45 and can last for years.<b><br><br><sprite=4> Sustainability:</b> Menstrual discs need to be changed every 12 hours, which is far less often than tampons and pads. Therefore, disposable discs generate less waste than many other disposable menstrual products. For a zero-waste option, opt for a reusable disc.<b><br><br><sprite=2> Bonus Points:</b> Menstrual discs are a good choice for playing sports or swimming because they collect blood inside rather than outside your body. They need to be changed less often than tampons and can stay in overnight. Because menstrual discs sit behind the pubic bone, rather than in the vaginal canal, they are the only product that can be worn while having penetrative sex.";
    private const string PadContent = "<size=19><b><sprite=5> How to Use:</b> Pads are pieces of absorbent material that attach to your underwear and catch blood. Pads vary in size and absorbency– some are designed to wear overnight and others are slim and meant for light-flow days. Most pads are disposable, though you can also use reusable cloth pads that must be washed between uses. To use a pad, simply remove the packaging and use the sticky strip to attach it to your underwear. If the pad has wings, wrap those around the bottom side of the underwear to hold it in place.<b><br><br><sprite=0> Coverage:</b> 3-4 hours.<b><br><br><sprite=3> How to Remove:</b> If using a disposable pad, unstick it from your underwear, wrap it in newspaper, and put it in the trash. Reusable pads should be soaked, facing down, in cold water for at least 30 minutes, rinsed, then washed with soap by hand or in a laundry machine.<b><br><br><sprite=1> Cost:</b> $6 per box of disposable pads at an average of 12 boxes per year = $72 per year. A pack of reusable pads costs about $20 to $35.<b><br><br><sprite=4> Sustainability:</b> Most disposable menstrual pads are 90% plastic, and along with their packaging, are equivalent to using 4 plastic bags. The plastic takes an estimated 500 to 800 years to decompose. For a more sustainable option, consider switching to reusable, machine-washable pads. <b><br><br><sprite=2> Bonus Points:</b> Menstrual pads are a beginner-friendly option, as they are completely external, and it is easy to see how much blood the pad has absorbed throughout the day.";
}
