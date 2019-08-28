using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class CardInit : MonoBehaviour
{
    private Card[] cardList;

    void Awake()
    {
        cardList = new Card[20];
        // visc - 1, temp - 2, amplify - 3, reverse - 4, N/A - 0
        //color: 0 red, 1 clear, 2 green, 3 blue, 4 yellow, 5 black, 6 purple
        //Name, component, degree, color, description
        cardList[0] = new Card("Mammoth Mead", 1, 2, 3, "Mammoth tears blah blah tasty and smooth");
        cardList[1] = new Card("Silkweed", 1, -2, 2, "Silkworms use this grass to see beyond this plane of existence, also makes you feel real good");
        cardList[2] = new Card("Raven's Claw", 3, 2, 5, "Those who consume this gain extreme intelligence");
        cardList[3] = new Card("Eye of the Tiger", 3,2,3, "Grants 'The Thrill of the Fight' giving you the strength to challenge your rivals");
        cardList[4] = new Card("Foglet Feet", 4, -1, 6, "Foglets often stomp around in mana pools which replicates the use of Haste spell in alchemy");
        cardList[5] = new Card("Spriggan Spine", 1, 1,3, "Forest Spriggans are kind souls that grant healing magic to those in need");
        cardList[6] = new Card("Dragon Dust", 0, 0, 1, "People say snorting this gives your fire breath");
        cardList[7] = new Card("Ghoul Gas", 1, -2 ,2, 2, 3, "The Fireball Dragonborn Association claims this causes instant death and poverty, better not use it");
        cardList[8] = new Card("Goblin Guts", 1, 1, 2, 1, 0, "REMINDER: THROW OUT GOBLIN GUTS, COMPLETELY USELESS!!!");
        cardList[9] = new Card("Satyr Scat", 2, 1, 4,
            "Satyr's radiate immense magical energy. Their excrement can be used to enhance future potion effects!!");
        cardList[10] = new Card("Angel Aloe", 1, 1, 2, -1, 4,
            "Tragically unsuccessful product, since angels already have perfect skin.");
        cardList[11] = new Card("Swamp Seed", 4, -1, 6,
            "Gross, gross, GROSS! Goes down awful but really fills your belly with magical energy...");
        cardList[12] = new Card("Liverwort", 1, -2, 0,
            "I've had nothing but bad trips with this little guy. Yeah college was a good time...");
        cardList[13] = new Card("Beholder's Buttocks", 2, 1, 6,
            "Very little people what the backside of a Beholder actually looks like. Even less survive to tell the tale.");
        cardList[14] = new Card("Unicorn Tears", 0, 0, 1,
            "Immoral to obtain and immoral to use. Oh the unspeakable horrors this could create...");
        cardList[15] = new Card("Love Moss", 1, 1, 2, -1, 6,
            "The main ingredient in a love potion. Possession of this hallucinogen is illegal but no one is going to find my stash");
        cardList[16] = new Card("Mercury", 0, 0, 5,
            "Consumed for its divine properties, said to grant the user immortality");
        cardList[17] = new Card("Quicksilver", 4, -1, 4,
            "For some reason has nothing to do with speed. I should coin a new term for the substance.");
        cardList[18] = new Card("Barghest Tail", 2, -1, 2,
            "This spectre causes immense pain at the touch. Wouldn't brew this for my worst enemies.");
        cardList[19] = new Card("Belial's Blood", 1, 2, 5,
            "This very nice demon gave me some of his blood for a potion. Demons really get a bad wrap");
        cardList[20] = new Card("Tortoise Toe Jam", 1, 1, 2, -1, 2,
            "Tortoises gather microscopic magical creatures between their toes that can be used for enhancing potions");
        cardList[21] = new Card("Baby's Laughter",3,2,0, "Don't open the jar or the laughter might escape! A child's youth can invigorate your potions with speed!!!" );
        cardList[22] = new Card("Liquid Guilt", 2, -2, 2,
            "I've been gathering this guilt for years now. I don't know how it can be used for potions but the guilt burns");
        cardList[23] = new Card("Yetti Yarrow", 2, -2, 0, "The Yetti were hunted to near extinction for their marrow due to a misprint in alchemy texts. Yetti Yarrow, however, grants the user immense power.");
        cardList[24] = new Card("Leviathan Lard", 1,2,4, "Boil and drink before bed for a good fortnights rest");
        cardList[25] = new Card("Pickpocket Pinky", 0,0,5, "This quick finger will have you moving quickly in no time.");
        cardList[26] = new Card("Broken Bracelet", 0,0,5, "A broken heart is said to cause death if the love was strong enough. This is because of the immense magical energy created by that love.");
        cardList[27] = new Card("Mandrake", 0,0,5, "The Mandrake root is said to sing lullabies when cooked and can provide nutrients for a week of meals.");
        
        
    
    }
}
/* for making your deck, do smth like:
public Card[] stack = new Card[stackSize];
for(int i = 0, i < stackSize, i++)
{
    stack[i] = cardList[Random.range(0,cardList.Length);
}

}*/
