using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class objectClicker : MonoBehaviour
{
    private bookAppear openBook;
    private bool isBookOpen;
    private changeText change1;
    private changeText2 change2;
    private string b1p1;
    private string b1p2;

    private string b2p1;
    private string b2p2;

    private string b3p1;
    private string b3p2;

    private string b4p1;
    private string b4p2;

    private string b5p1;
    private string b5p2;

    private string b6p1;
    private string b6p2;

    private string b7p1;
    private string b7p2;

    private string text1;
    private string text2;


    void Start() {
    //    openBook = GameObject.Find("Open_Book/openBook");
    
        isBookOpen = false;
        openBook = FindObjectOfType<bookAppear>();
        change1 = FindObjectOfType<changeText>();
        change2 = FindObjectOfType<changeText2>(); 
        b1p1 = "Sing to me of the man, Muse, the man of twists and turns ... driven time and again off course, once he had plundered the hallowed heights of Troy. Many cities of men he saw and learned their minds, many pains he suffered, heartsick on the open sea, fighting to save his life and bring his comrades home. But he could not save them from disaster, hard as he strove the recklessness of their own ways destroyed them all, the blind fools,";
        b1p2 = " they devoured the cattle of the Sun and the Sungod blotted out of the day of their return. Launch out on his story, Muse, daughter of Zeus start from where you will—sing for our time too. \nBy now, all the survivors, all who avoided headlong death were safe at home, escaped the wars and waves. \nBut one man alone... his heart set on his wife and his return.";

        b2p1 = "The trembling priest along the shore return\'d, And in the anguish of a father mourn\'d. Disconsolate, not daring to complain, silent he wander\'d bvy the sounding main. Till, safe at ditance, to his god hi prays, the god who darts around the world his rays. \"O Smintheus! Sprung from fair Latona\'s line, Thou guardian power of Cilla the divine, thou source of light! whom Tenedos adores, and whose bright presence gilds thy Chrysa\'s shores.";
        b2p2 = "If e\'er with wreaths I hung thy sacred fane, or fed the flames with fat of oxen slain, god of the silver bow! thy shafts emply, Avenge thy servant, and the greeks destroy!\" \nThus Chryses pray\'d.--hte favouring power attends, And from Olympus\' lofty tops descends. Bent was his bow, the Grecian hearts to wound. Beathing revenge, a sudden night he spread, And gloomy darkness roll\'d about his head.";

        b3p1 = "A spectre is haunting Europe -- the spectre of COMMUNISM. All the powers of old Europe have entered into a holy alliance to exorcise this spectre. Pope and Tsar, Metternich and Guizot, French Radicals and German police-spies. Where is the party in opposition that has not been decried as communistic by its opponents in power? Where is the opposition that has not hurled back the brandind reproach of communism, against the more advanced opposition parties, as well";
        b3p2 = "as against its reactionary adversaries? \nThe history of all hitherto existing society is the history of class struggles. Freeman and slave, patrician and plebeian, lord and serf, guild-master and journeyman, in a word, oppressor and oppressed, stood in constant opposition to one another, carried on an uninterrupted, now hidden, now open fight, a fight that each time ended, either in a revolutionary reconstitution of society at large, or in the common ruin of the contending classes.";

        b4p1 = "In a hole in the ground there lived a hobbit. Not a nasty, dirty, wet hole, filled with the ends of worms and an oozy smell, nor yet a dry, bare, sandy hole with nothing in it to sit down on or to eat: it was a hobbit-hole, and that means comfort. \nIt had a perfectly round door like a porthole, painted green, with a shiny yellow brass knob in the exact middle. The door opened on to a tubeshaped hall like a tunnel: a very";
        b4p2 = "comfortable tunnel without smoke, with panelled walls, and floors tiled and carpeted, provided with polished chairs, and lots and lots of pegs for hats and coats - the hobbit was fond of visitors. The tunnel wound on and on, going fairly but not quite straight into the side of the hill - The Hill, as all the people for many miles round called it - and many little round doors opened out of it, first on one side and then on another.";

        b5p1 = "En un lugar de la Mancha, de cuyo nombre no quiero acordarme, no ha mucho tiempo que vivía un hidalgo de los de lanza en astillero, adarga antigua, rocín flaco y galgo corredor. Una olla de algo más vaca que carnero, salpicón las más noches, duelos y quebrantos los sábados, lantejas los viernes, algún palomino de añadidura los domingos, consumían las tres partes de su hacienda. El resto della concluían sayo de velarte, calzas de velludo para";
        b5p2 = "las fiestas, con sus pantuflos de lo mesmo, y los días de entresemana se honraba con su vellorí de lo más fino. Tenía en su casa una ama que pasaba de los cuarenta y una sobrina que no llegaba a los veinte, y un mozo de campo y plaza que así ensillaba el rocín como tomaba la podadera. Frisaba la edad de nuestro hidalgo con los cincuenta años. Era de complexión recia, seco de carnes, enjuto de rostro, gran madrugador y amigo de la caza.";

        b6p1 = "Ash fell from the sky. \nLord Tresting frowned, glancing up at the ruddy midday sky as his servants scuttled forward, opening a parasol over Tresting and his distinguished guest. Ashfalls weren’t that uncommon in the Final Empire, but Tresting had hoped to avoid getting soot stains on his fine new suit coat and red vest, which had just arrived via canal boat from Luthadel itself. Fortunately, there wasn’t much wind;";
        b6p2 = "the parasol would likely be effective.\n Tresting stood with his guest on a small hilltop patio that overlooked the fields. Hundreds of people in brown smocks worked in the falling ash, caring for the crops. There was a sluggishness to their efforts—but, of course, that was the way of the skaa.The peasants were an indolent, unproductive lot. They didn’t complain, of course; they knew better than that.";

        b7p1 = "Now! We Spear-Danes, in ages gone, Days of the clan-kings, knew glory. How those princes did mighty deeds. Shield Sheafson seized mead-benches From many a man, among his enemies; That terror of warriors flourished later, After his first rescue as foundling Waxed under heaven, grew in honour, Till near tribes, over the whale-road, Had to yield to him, forced to submit, Offer him tribute. That was a fine king!";
        b7p2 = "After, a boy-child was born to him, A lad in the yard, sent there by God To comfort the people; He had seen What they had suffered; leaderless A long while; so the Lord of Life, Wielder of Glory, granted him honour; Beaw was known -– his fame flew wide -– Heir to Shield, in the Northern lands. So should a lad do, working good deeds, Giving gifts freely in his father’s house.";

        text1 = "";
        text2 = "";
    }

    // Update is called once per frame
    private void Update() {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (!isBookOpen) {
            if (Input.GetMouseButtonDown(0)) {
                if (Physics.Raycast(ray, out hit, 500.0f)) {
                    if (hit.transform != null) {
                        print(hit.transform.gameObject.name);
                        isBookOpen = openBook.open();
                        if (hit.transform.gameObject.name == "book00") {
                            text1 = b1p1;
                            text2 = b1p2;
                        } else if (hit.transform.gameObject.name == "book01") {
                            text1 = b2p1;
                            text2 = b2p2;
                        } else if (hit.transform.gameObject.name == "book02") {
                            text1 = b3p1;
                            text2 = b3p2;
                        } else if (hit.transform.gameObject.name == "book03") {
                            text1 = b4p1;
                            text2 = b4p2;
                        } else if (hit.transform.gameObject.name == "book04") {
                            text1 = b5p1;
                            text2 = b5p2;
                        } else if (hit.transform.gameObject.name == "book05") {
                            text1 = b6p1;
                            text2 = b6p2;
                        } else if (hit.transform.gameObject.name == "book06") {
                            text1 = b7p1;
                            text2 = b7p2;
                        }

                        change1.change(text1);
                        change2.change(text2);
                        
                        
                    }
                }
            }   
        } else {
            if (Input.GetKeyDown(KeyCode.Escape)) {
                isBookOpen = openBook.close();
            }
        }
        
    }

    private void PrintName(GameObject go) {
        print(go.name);
    }
}
