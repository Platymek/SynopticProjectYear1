using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace synopticProject.Source
{
    internal class Map
    {
        public static Organism GetOrganism(string name)
        {
            foreach (Organism o in Organisms) if (o.Name.Equals(name)) return o;
            //throw new OrganismNotFoundException(name);
            return null;   
        }

        public static Location GetLocation(string name)
        {
            foreach (Location locationToCheck in Locations)
            {
                if (locationToCheck.Name == name)
                {
                    return locationToCheck;
                }
            }
            return null;
        }

        public static Location GetNearestLocation(Vector2 position)
        {
            
            Location nearestLocation = Locations[0];

            foreach (Location currentLocation in Locations)
            {
                float d1 = Vector2.DistanceSquared(position, nearestLocation.Position) - nearestLocation.Radius;
                float d2 = Vector2.DistanceSquared(position, currentLocation.Position) - currentLocation.Radius;

                if (d1 < d2) nearestLocation = currentLocation;
            }
            
            return nearestLocation;
        }

        private static string[] Descriptions = new string[]
        {
            "Although members of most wallaby species are small, some can grow up to approximately two metres in length (from the head to the end of the tail). Their powerful hind legs are not only used for bounding at high speeds and jumping great heights, but also to administer vigorous kicks to fend off potential predators. The tammar wallaby (Notamacropus eugenii) has elastic storage in the ankle extensor tendons, without which the animal's metabolic rate might be 30?50% greater.[5] It has also been found that the design of spring-like tendon energy savings and economical muscle force generation is key for the two distal muscle?tendon units of the tammar wallaby (Macropus-Eugenii).[6] Wallabies also have a powerful tail that is used mostly for balance and support.",
            "The fur is short, pale at the ventral side and grading to a reddish tan colour over the upper parts of the pelage. Females have similar coloration, although lighter and with greyish fur at the head and shoulders. A patch or stripe of paler coloured fur is seen at the lower part of the head, and a lighter colour at the inside and edge of the ear sharply contrasts with the darker fur colour of outer side. The paws of the front and hind legs are very dark, and contrast the lighter fur of the lower limb. Their tails are thickly covered in fur, a uniform width along its length, and a paler shade of the upper body colour. The bare skin of the rhinarium is black",
            "The common spotted cuscus is about the size of a common house cat, weighing 1.5 to 6 kilograms (3.3 to 13.2 lb), body size about 35 to 65 centimetres (14 to 26 in) long, and a tail 32 to 60 centimetres (13 to 24 in) long.",
            "The freshwater crocodile is a relatively small crocodilian. Males can grow to 2.3?3.0 m (7.5?9.8 ft) long, while females reach a maximum size of 2.1 m (6.9 ft).[9] Males commonly weigh around 70 kg (150 lb), with large specimens up to 100 kg (220 lb) or more, against the female weight of 40 kg (88 lb). This species is shy and has a slenderer snout and slightly smaller teeth than the dangerous saltwater crocodile. The body colour is light brown with darker bands on the body and tail?these tend to be broken up near the neck. Some individuals possess distinct bands or speckling on the snout. Body scales are relatively large, with wide, close-knit, armoured plates on the back. Rounded, pebbly scales cover the flanks and outsides of the legs.",
            "Considered the largest species in the Bufonidae, the cane toad is very large; the females are significantly longer than males, reaching a typical length of 10?15 cm (4?6 in),[ with a maximum of 24 cm (9.4 in). Larger toads tend to be found in areas of lower population density. They have a life expectancy of 10 to 15 years in the wild, and can live considerably longer in captivity, with one specimen reportedly surviving for 35 years.",
            "The dingo is a medium-sized canine that possesses a lean, hardy body adapted for speed, agility, and stamina. The dingo's three main coat colourations are light ginger or tan, black and tan, or creamy white.[18][19] The skull is wedge-shaped and appears large in proportion to the body.",
            "The common ringtail possum weighs between 550 and 1100 g and is approximately 30?35 cm long when grown (excluding the tail, which is roughly the same length again). It has grey or black fur with white patches behind the eyes and usually a cream coloured belly. It has a long prehensile tail which normally displays a distinctive white tip over 25% of its length. The back feet are syndactyl which helps it to climb. The ringtail possum's molars have sharp and pointed cusps",
            "",
            "A feral horse is a free-roaming horse of domesticated stock. As such, a feral horse is not a wild animal in the sense of an animal without domesticated ancestors. However, some populations of feral horses are managed as wildlife, and these horses often are popularly called 'wild' horses. Feral horses are descended from domestic horses that strayed, escaped, or were deliberately released into the wild and remained to survive and reproduce there. Away from humans, over time, these animals' patterns of behavior revert to behavior more closely resembling that of wild horses. Some horses that live in a feral state but may be occasionally handled or managed by humans, particularly if privately owned, are referred to as 'semi-feral'.",
            "A feral pig is a domestic pig that has escaped or been released into the wild, and is living more or less as a wild animal, or one that is descended from such animals.[1] Zoologists generally exclude from the feral category animals that, although captive, were genuinely wild before they escaped.[2] Accordingly, Eurasian wild boar, released or escaped into habitats where they are not native, such as in North America, are not generally considered feral, although they may interbreed with feral pigs.[3] Likewise, reintroduced wild boars in Western Europe are also not considered feral, despite the fact that they were raised in captivity prior to their release.",
            "Males can weigh from 11.5 kg up to almost 14 kg (25 to 31 lbs), while the females range between about 8 to 10.6 kg (17.6 to 23 lbs). They are very agile and are able to leap 9 metres (30 ft) down to another branch and have been known to drop as far as 18 metres (59 ft) to the ground without injury.",
            "Tree frogs are usually tiny as their weight has to be carried by the branches and twigs in their habitats. While some reach 10 cm (4 in) or more, they are typically smaller and more slender than terrestrial frogs. Tree frogs typically have well-developed discs at the finger and toe tips; the fingers and toes themselves, as well as the limbs, tend to be rather small, resulting in a superior grasping ability. The genus Chiromantis of the Rhacophoridae is most extreme in this respect: it can oppose two fingers to the other two, resulting in a vise-like grip.",
            "The family ranges in size from the 5-gram black-bellied sunbird to the spectacled spiderhunter, at about 45 grams. Like the hummingbirds, sunbirds are strongly sexually dimorphic, with the males usually brilliantly plumaged in iridescent colours.[3] In addition to this the tails of many species are longer in the males, and overall the males are larger. Sunbirds have long thin down-curved bills and brush-tipped tubular tongues, both adaptations to their nectar feeding.[4] The spiderhunters, of the genus Arachnothera, are distinct in appearance from the other members of the family. They are typically larger than the other sunbirds, with drab brown plumage that is the same for both sexes, and long, down-curved beaks",
            "It is a large bird with black feathers and a red head. Its total length is about 60?75 cm (23.5?29.5 in) and a wingspan of about 85 cm (33 in). The subspecies A. l. purpureicollis from the northern Cape York Peninsula is smaller than the more widespread nominate subspecies. It has a prominent, fan-like tail flattened sideways, and its plumage is mainly blackish, but with a bare red head, and a yellow (in the nominate subspecies) or purple wattle (in A. l. purpureicollis). The males' wattles become much larger during breeding season, often swinging from side to side as they run. The males' heads and wattles also become much brighter during the breeding and nesting season. The underside of the body is sprinkled with white feathers, more pronounced in older birds. The brushturkey is a clumsy flyer and cannot fly long distances, only taking to the air when threatened by predators or to roost in trees at night and during the heat of the day.",
            "The amethystine python (Simalia amethistina), also known as the scrub python or sanca permata locally, is a species of non-venomous snake in the family Pythonidae. The species is found in Indonesia, Papua New Guinea, and Australia. Popular among reptile enthusiasts, and noted for its coloration and size, it is one of the six largest snakes in the world, as measured either by length or weight, and is the largest native snake in Australia and Papua New Guinea",
            "The Pied Imperial Pigeon is a large plump pigeon. It is entirely white or pale cream, apart from black flight feathers and tail feathers. The head can be brown, soiled by eating fruit. The legs and bill are a bluish color and the iris of the eye is brown. Its flight is fast and direct, with the regular beats and an occasional sharp flick of the wings which are characteristic of pigeons in general.",
            "The morepork is 26 to 29 cm (10 to 11.5 in) long, with the female slightly larger than the male. Females are slightly heavier at 170?216 g (6.0?7.6 oz) compared with the male's 140?156 g (4.9?5.5 oz).[13] The morepork has generally dark brown head and upperparts, with pale brown spots on head and neck and white markings on the rest of the upperparts, with a pale yellow-white supercilium (eyebrow), dark brown ear coverts, and buff cheeks.[14] The eyes are yellow to golden-yellow.[15] The feathers of the chin and throat are buff with dark brown shafts. The feathers of the underparts are mostly dark brown with buff and white spots and streaks, with the larger markings on the belly making it look paler overall. The upper tail is dark brown with lighter brown bars.[14] The cere and bill is pale blue-grey with a black cutting edge. The feet are orange or yellow with blackish claws.",
            "The wings are black, green and white with a yellow band across the flight feathers. The tail is black with a whitish tip. The throat, breast and belly are white, sometimes with a yellow wash, and the flanks are yellowish. The female is of a more somber brownish tone and her head and back are flecked with ochre. Both birds have white eyebrow stripes. They have short, rounded wings, a very short tail and a long thin awl-like bill which is brownish and slightly upturned for insertion into cracks",
            "have dark-reddish brown or blackish brown upperparts which are irregularly marked with white patches.[4][5] Their underparts are usually white, but in one colour phase it can be dark brown.[4][5] They have no wing pouch or in other words, a poorly developed radio-metacarpal pouch.[4] They have a distinct glandular pouch on the throat.[4][5] The ear is short and broadly rounded with ribbing on the interior of the pinna with a short tragus which has a semicircular margin.[4] It has long and narrow wings with black skin and translucent whitish portions.[4] It is the largest species with the whitest wings.",
            "Typically, all cassowaries are shy birds that are found in the deep forest. They are adept at disappearing long before a human knows they were there. The southern cassowary of the far north Queensland rain forests is not well studied, and the northern and dwarf cassowaries even less so. Females are larger and more brightly coloured than the males. Adult southern cassowaries are 1.5 to 1.8 m (5 to 6 ft) tall, although some females may reach 2 m (6.6 ft),[18] and weigh 58.5 kg (130 lb).[12]",
            "The eclectus parrot (Eclectus roratus) is a parrot native to the Solomon Islands, Sumba, New Guinea and nearby islands, northeastern Australia, and the Maluku Islands (Moluccas). It is unusual in the parrot family for its extreme sexual dimorphism of the colours of the plumage; the male having a mostly bright emerald green plumage and the female a mostly bright red and purple/blue plumage. Joseph Forshaw, in his book Parrots of the World, noted that the first European ornithologists to see eclectus parrots thought they were of two distinct species. Large populations of this parrot remain, and they are sometimes considered pests for eating fruit off trees. Some populations restricted to relatively small islands are comparably rare. Their bright feathers are also used by native tribespeople in New Guinea as decorations.",
            "It has a moderate body with a medium length, slender tail. Its scales are smooth. The back and sides are greyish-brown to rich brown, often with darker and paler flecks. A narrow yellowish-brown stripe is usually present on the outer edge of the back. The species can also have two distinct forms: a prominent white stripe and a less prominent white stripe. This dimorphism is not strictly distinguished by gender.",
            "Like all paradise kingfishers, the buff-breasted is brightly coloured with a large red bill, rich rufous-buff underparts, blue or purple cap, crown and outer tail feathers, black eye stripes running down to the nape of its neck, red feet, white lower back and rump and long white or blue-and-white tail-feathers which varies geographically.[15] The identifying feature is the white patch on the centre of the upper back.[16] The juvenile has a brown bill, yellowish feet, is duller and lacks long tail feathers.",


            "Typical for most ant plants are the hypocotyls, which are stems that enlarge to form a tuber-like structure. In Myrmecodia beccarii, these hypocotyls are covered in ridges and spines. The white flowers are not very conspicuous, as they are formed in hollows along the alveoli (stem). The ripe fruit then protrudes from the alveoli and they can be white, red, orange or pink.",
            "Cycads form an order of woody-stemmed plants, some with a stout colomnar trunk (called a caudex) a metre or so tall, and other with the caudex wholly underground. Their trunks consist of a core of fleshy conducting tissues with a tough, thick outer layer made up of rows of persistent leaf-bases terminating in a cluster of long leaves (or fronds) bearing many leaflets. They grow as either male or female plants, the males bearing narrow elongated cones which produce pollen: the females produce much larger seed cones which, when mature, break open allowing the seeds to fall to the ground.",
            "It has dark, deeply furrowed ironbark, lance-shaped adult leaves, flower buds in groups of seven, white, red, pink or creamy yellow flowers and cup-shaped to shortened spherical fruit.",
            "Its inconspicuous flowers are arranged in clusters on short spikes 3?6 mm long.[6][7] Only one flower on each spike eventually forms a fruit.[2][6] The inedible fruit is a globular, hard, greenish nut, 4-6mm long, containing one seed. It is found on top of a short stalk, the pedicel. As the fruit develops the stalk swells to 5-6mm in diameter and turns yellow or red, to form the edible 'cherry' (which lacks the hard stone of a European cherry).",
            "a distinctive palm with a single trunk to 10 m (33 ft) in height and 10 cm (3.9 in) diameter.[2] It has large, pleated, circular leaves up to 2 m (6 ft 7 in) in diameter. Petioles have formidable spines to 5 mm (0.20 in) long. The fruits are a red drupe around 10 mm (0.39 in) diameter containing a single seed",
            "Beginning life as a sticky seed left on a high tree branch by an animal such as a bird, bat, or monkey, the young strangler lives as an epiphyte on the tree?s surface. As it grows, long roots develop and descend along the trunk of the host tree, eventually reaching the ground and entering the soil. Several roots usually do this, and they become grafted together, enclosing their host?s trunk in a strangling latticework, ultimately creating a nearly complete sheath around the trunk. The host tree?s canopy becomes shaded by the thick fig foliage, its trunk constricted by the surrounding root sheath, and its own root system forced to compete with that of the strangling fig.",
            "Plants in this genus are evergreen shrubs or small trees, with the exception of the aptly-named giant stinging tree (D. excelsa) which may reach 35 m (115 ft) in height.[3] Dendrocnide species have a sympodial growth habit and are armed with fine needle-like stinging hairs. They are generally fast-growing and produce soft wood, and are usually found in areas of disturbed forest where they fill the role of a pioneer species.",
            "",
            "The leaves are simple, alternate, and petiolate, (i.e. having long petioles or leaf-stems), and the leaf blade may be either entire or have some form of dentate toothing (notches or teeth on the edges of the leaf). The leaves are also often large, and may be either leathery or papery. The stipules are fused and deciduous, leaving conspicuous scars on the twigs after falling.",
            "",
            "The inflorescences are axillary and pedunculate, flowers are either solitary or in racemes or panicles. Male flowers may be 4- or 5-merous and the female flowers are 4-merous. Most species are dioecious, a small number are monoecious.",
            "",
            ""
        };

        public static Organism[] Organisms { get; private set; } = new Organism[]
    {
            // TODO: Add all organisms
            
            new Fauna("Wallaby",                    Descriptions[ 0], 0, 0),
            new Fauna("Antilopine Wallaroo",        Descriptions[ 1], 0, 0),
            new Fauna("Spotted Cuscus",             Descriptions[ 2], 0, 0),
            new Fauna("Saltwater Crocodile",        Descriptions[ 3], 0, 1),
            new Fauna("Cane Toad",                  Descriptions[ 4], 0, 1),
            new Fauna("Dingo",                      Descriptions[ 5], 1, 1),
            new Fauna("Possum",                     Descriptions[ 6], 0, 0),
            new Fauna("Feral Cattle",               Descriptions[ 7], 0, 0),
            new Fauna("Feral Horse",                Descriptions[ 8], 0, 0),
            new Fauna("Feral Pig",                  Descriptions[ 9], 0, 2),
            new Fauna("Tree Kangaroo",              Descriptions[10], 0, 0),
            new Fauna("Tree Frog",                  Descriptions[11], 1, 0),
            new Fauna("Sunbird",                    Descriptions[12], 1, 0),
            new Fauna("Bush Turkey" ,               Descriptions[13], 0, 0),
            new Fauna("Amethystine Python",         Descriptions[14], 0, 0),
            new Fauna("Imperial Pigeon",            Descriptions[15], 0, 0),
            new Fauna("Morepork",                   Descriptions[16], 0, 0),
            new Fauna("Riflemen",                   Descriptions[17], 0, 0),
            new Fauna("Bare-Rumped SheathTail Bat", Descriptions[18], 0, 0),
            new Fauna("Cassowary",                  Descriptions[19], 1, 2),
            new Fauna("Electus Parrot",             Descriptions[20], 0, 0),
            new Fauna("Skink",                      Descriptions[21], 0, 0),
            new Fauna("Buff Breasted Kingfisher",   Descriptions[22], 0, 0),

            new Flora("Ant Plant",                  Descriptions[23], 1, 0),
            new Flora("Ancient Cycad",              Descriptions[24], 1, 2),
            new Flora("Ironbark Eucalyptus",        Descriptions[25], 1, 0),
            new Flora("Wild Cherry",                Descriptions[26], 0, 0),
            new Flora("Fan Palm",                   Descriptions[27], 0, 0),
            new Flora("Strangler Fig",              Descriptions[28], 0, 0),
            new Flora("Stinging Tree",              Descriptions[29], 0, 0),
            new Flora("Melaleuca",                  Descriptions[30], 0, 0),
            new Flora("Stringybark",                Descriptions[31], 0, 1),
            new Flora("Wattle",                     Descriptions[32], 0, 0),
            new Flora("Termite Mound",              Descriptions[33], 0, 0),
            new Flora("Fern",                       Descriptions[34], 0, 0),
            new Flora("Orchid",                     Descriptions[35], 0, 0),
        };


        public static Location[] Locations { get; private set; } = new Location[]
        {
            // TODO: Add all locations
            new Location("Iron Range", new Vector2(-12.5975f, 143.4111f), 1, new Organism[]
            { 
                GetOrganism("Spotted Cuscus"),
                GetOrganism("Saltwater Crocodile"),
                GetOrganism("Riflemen"),
                GetOrganism("Bare-Rumped SheathTail Bat"),
                GetOrganism("Cassowary"),
                GetOrganism("Electus Parrot"),
                GetOrganism("Ant Plant"),
                GetOrganism("Fern"),
                GetOrganism("Orchid"),
            }),
            new Location("Daintree Rainforest", new Vector2(-16.1700f, 145.4185f),       1, new Organism[]
            { 
                GetOrganism("Cane Toad"),
                GetOrganism("Dingo"),
                GetOrganism("Possum"),
                GetOrganism("Tree Kangaroo"),
                GetOrganism("Tree Frog"),
                GetOrganism("Bush Turkey"),
                GetOrganism("Imperial Pigeon"),
                GetOrganism("Cassowary"),
                GetOrganism("Fan Palm"),
                GetOrganism("Strangler Fig"),
                GetOrganism("Stinging Tree")
            }),
            new Location("Lakefield",           new Vector2(-15.53092f, 143.75705f),    1, new Organism[]
            { 
                GetOrganism("Wallaby"),
                GetOrganism("Saltwater Crocodile"),
                GetOrganism("Cane Toad"),
                GetOrganism("Dingo"),
                GetOrganism("Possum"),
                GetOrganism("Feral Cattle"),
                GetOrganism("Feral Horse"),
                GetOrganism("Feral Pig"),
                GetOrganism("Tree Frog"),
                GetOrganism("Melaleuca"),
                GetOrganism("Stringybark"),
                GetOrganism("Wattle")
            }),
            new Location("Oyala Thumotang",     new Vector2(-13.684401f, 142.887187f),  1, new Organism[]
            { 
                GetOrganism("Wallaby"),
                GetOrganism("Antilopine Wallaroo"),
                GetOrganism("Spotted Cuscus"),
                GetOrganism("Saltwater Crocodile"),
                GetOrganism("Melaleuca"),
                GetOrganism("Ironbark Eucalyptus"),
                GetOrganism("Termite Mound")
            }),
            new Location("Mt Cook",          new Vector2(-15.733333f, 145.100000f),  1, new Organism[]
            {
                GetOrganism("Bush Turkey"),
                GetOrganism("Amethystine Python"),
                GetOrganism("Imperial Pigeon"),
                GetOrganism("Morepork"),
                GetOrganism("Skink"),
                GetOrganism("Buff Breasted Kingfisher"),
                GetOrganism("Ancient Cycad"),
                GetOrganism("Ironbark Eucalyptus"),
                GetOrganism("Wild Cherry"),
            }),
        };

    }

}
