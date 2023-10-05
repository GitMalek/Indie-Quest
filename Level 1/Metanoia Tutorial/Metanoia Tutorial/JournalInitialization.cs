using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metanoia_Tutorial
{
    internal partial class Program
    {
        // Origin Locations
        static JournalEntry Symposia = new JournalEntry()
        {
            EntryName = "Symposia",
            EntryDescription = "Symposia is the infinite frontier, created by Oberon - god of the tale. The land is non-euclidian in nature, some say Oberon personally shifts the location of ruins and civilizations that dot the land to make the most interesting stories. Symposia can be truly bountiful, but all those within it are tested rigurously for their right to remain within it. It is said all roads lead to Symposia in one way or another, though there are known borders in the world- one can reach it by land, sea, or air if they wander long enough without a destination.",
            CreationEntryContextText = "Your family was among the many settlers of Symposia, you were born and raised there. Though you at some point left for the world that was more set in stone, you're finally returning home.",
            EntryFamiliarity = 0
        };

        static JournalEntry Akros = new JournalEntry()
        {
            EntryName = "Akros",
            EntryDescription = "Akros is the halidom of duality. Founded on the worship of Alytheos, the populus are taught to embrace a balance of sin and virtue for a greater good. The land is split into two militaristic, philosophical, and political factions- Astra and Umbra. Astra is known to lean more on the side of caution, espousing virtue and honor- keeping Umbra in check, though no Astran would eschew sin entirely. Umbra on the other hand values progress and efficiency, indulging more in deceit and sin for the greater good. Despite their differences, the parties recognize the need of the other to keep the whole in check.",
            CreationEntryContextText = "You hail from Akros, whether your life was that of a citizen, a noble, or a knight- you were no doubt exposed to the city's many intrigues. This includes some knowledge of the faceless, Akros' open secret. The faceless are humans blessed by Alytheos to don new or existing identities at will- though the nature of their existence and level of coordination is hotly debated by the public. You also align with either Astra or Umbra, or you never opted to wholly align yourself with either philosophy",
            EntryFamiliarity = 0
        };

        static JournalEntry Frijia = new JournalEntry()
        {
            EntryName = "Frijia",
            EntryDescription = "Frijia is the winter's rest. Covered in constant snow to the north, with lush greenery to the south- The Frijian lands and islands have one thing common all across. The necessity of strength and wit. Huge beasts of all sorts dot the landscape, and disparate tribes compete for land and resources regularly. Relatively recently, a 'capital' arose within Frijia, lead by a winter king that seeks the support of all of the tribes. The cultures of the tribes that form within Frijia are immensely varied, but typically center around a founding ideal such as guile, brute force, or diplomacy",
            CreationEntryContextText = "You are from the Frijian lands. Whether you're a citizen of the newly formed capital, or you're a member of one of the various tribes- you grew up knowing the value of might in survival. The harsh weather, occasional tribal raids, and relentless predators have hardened you.",
            EntryFamiliarity = 0
        };

        static JournalEntry Eudaina = new JournalEntry()
        {
            EntryName = "Eudaina",
            EntryDescription = "Eudaina is the art capital of the world. It was the first civilization to form after the Shuddering, lead by noble families that trace their heritage back to Oberon's first elves. Beauty, elegance and majesty is extremely valued within Eudaina. Master artists of all sorts emerge within and flock to it. Most of the populus worship Oberon and Lysia, and uphold fanciful notions such as chivalry and valor even in warfare.",
            CreationEntryContextText = "Being from Eudaina means an exposure to arts of all sorts. Song and dance, writings and paintings, and cities sculpted as pieces of art in and of themselves. It's difficult to find a better understanding of elegance and grace anywhere else.",
            EntryFamiliarity = 0
        };

        static JournalEntry NewShinari = new JournalEntry()
        {
            EntryName = "New Shinari",
            EntryDescription = "New Shinari is a technocracy built on the remains of a massive tower constructed to connect all of humanity. The old Shinari civilization advanced through technological progress at an alarming rate, until the network they constructed inadvertently caused the Shuddering. Ever since, technological progress has been difficult to share and evolve, but the citizens of New Shinari still pursue it despite the new challenges. The upper steps of the tower are fitted with universities and laboratories of all sorts, while the lower steps typically make their livings exploring the ruins of Shinari the tower is built on for relics of the past.",
            CreationEntryContextText = "As a New Shinaran, you grew up surrounded by technology on a scale the rest of the world simply wouldn't understand. Wonders of artifice and the fruits of craftsmen's labor surrounded you throughout your life. You were either born in the hardened lower steps- the hardened bedrock of New Shinari, focused on practical and simple technology to extract more out of the ruins they inhabit... or the upper steps; the refined and structured section of the capital where scholars discuss the theoretical future of technologyy",
            EntryFamiliarity = 0
        };

        static JournalEntry Miasmire = new JournalEntry()
        {
            EntryName = "Miasmire",
            EntryDescription = "Miasmire is a land of shadow and war. A rift of unknown origin poisoned the land, blocking the sky with a thick miasma and allowing demons and devils to occasionally seep through. The land is home to practicioners of taboo magics, and people that have twisted themselves into monsters. Worship of Eradius is somewhat common- but most that dwell within Miasmire prioritize self-interest regardless.",
            CreationEntryContextText = "Living in Miasmire has a lot of implications. Monsters aside, the civilizations that exist there function asserting dominance and control. Whether you lived as a willing or unwilling servant to the strong, or one of those that thought to control the weak- or a hermit trying to get by, you're no stranger to the strange culture of Miasmire",
            EntryFamiliarity = 0
        };

        static JournalEntry LandsBetweenAndBeyond = new JournalEntry()
        {
            EntryName = "Lands Between And Beyond",
            EntryDescription = "Symposia attracts all sorts, not just the major civilizations of a sole continent. Be it the wilderness in between these lands- or another continent altogether, travellers can reach it just fine all the same.",
            CreationEntryContextText = "Though you don't call one of those civilizations home, you're certainly well travelled. Symposia connects to all lands one way or another, and sufficient travel is enough to take you there- whether it's aimless or if it's one's goal to reach it. Regardless of whether you're from a small hamlet, the wilderness, or another continent altogether- you've likely seen quite a lot beyond the more metropolitan areas",
            EntryFamiliarity = 0
        };

        
        // Heritages
        static JournalEntry Human = new JournalEntry()
        {
            EntryName = "Human",
            EntryDescription = "The most common inhabitants of the land, humans are the baseline from which most other peoples descend from. Though they don't have the blessings of any particular magic or god, there's no limits to what they can accomplish with dedication.",
            CreationEntryContextText = "As a human, you could be from mostly anywhere. Humans are the majority of most populations.",
            EntryFamiliarity = 0
        };

        static JournalEntry Elves = new JournalEntry()
        {
            EntryName = "Elves",
            EntryDescription = "The first elves came about after the Shuddering, Oberon rewarded his most faithful followers at the time by turning them into the first elves. They were granted eternal youth- however it came with a caveat. That youth would only be maintained for as long as the elves are able ot fill their lives with deep meaning. If an elf enters a dull period, they age normally and take on all the detriments that come with it. The longer an elf lives, the harder it is for the 'meaning' they find in their life to be sufficient to stave off the aging.",
            CreationEntryContextText = "As an elf, you've either lived much longer than humans= or you expect to. Long lived elves are often eccentric and dedicated to their niches to an incredible degree, and their cultures are incredibly varied and novel to allow for their continued existence. Humans view elves as somewhat alien, aloof or mystical. Though it's sometimes the case due to their investment in maintaining their youth, their ancestors were also human once.",
            EntryFamiliarity = 0
        };

        // Gods
        static JournalEntry Oberon = new JournalEntry()
        {
            EntryName = "Oberon",
            EntryDescription = "Oberon is the god of narrative, stories, and the tale. He announced his presence after the shuddering, announcing that humanity's collective search for meaning after the global existential crisis is what created him. Ever since, he's directly interfered in the material world for quite some time. Oberon first created the faefolk and their groves to spark more legends and tales, then he turned the first of his faithful into the elves- promised eternal youth only for as long as they can fill their lives with meaning. Finally, he created Symposia- a land built to ensure humanity never lacks in potential for adventure or challenges.",
            CreationEntryContextText = "Worshippers of Oberon follow him for a multitude of reasons. Most elves follow him out of a sense of gratitude for their longevity- or they believe that appealing to him allows them to maintain their youth for longer, although it hasn't seemed to factor into the equation. Others are writers that respect his prowess to turn legends into reality, and some simply believe that faith in him fills their life with a beautiful appreciation for their own potential. Oberon's followers seek to turn their life into a legend he'll one day tell those that come after them.",
            EntryFamiliarity = 0
        };

        static JournalEntry Alytheos = new JournalEntry()
        {
            EntryName = "Alytheos",
            EntryDescription = "Alytheos is the godess of duality. Alytheos was a saint in the time she walked the land, a redeemer godess that always wore a mask and hood- involving herself in the dealings of criminals and sinners, Alytheos would study their operations and subtly guide them to improving their efficiency in ways that benefited the general populus. A drug operation would be coaxed to use their knowledge for medicine production, a thief would be nudged to track items of value to return them to wealthy owners. Alytheos opted to become the warden of Nyx- the realm departed souls went when rejected by the other gods. Initially, Alytheos would reform these souls subtly before allowing them to reincarnate. Eventually, the essence of Nyx itself corrupted the souls- creating the first fiends. Alytheos was forced back, into a citadel of their creation that orbits the edge of Nyx.",
            CreationEntryContextText = "Upon Alytheos' exodus from Nyx, she became distant with their connection to the material world. She turned her most faithful into the first Faceless and tasked them with the creation of Akros. Akos' main doctrine for Alytheos worship is the ordinance, the teachings suggest their followers explore the depths of sin and virtue to the best of their abilities- so that one day they may join Alytheos in her citadel after death, either to retake Nyx or to act as judges for souls beyond redemption. Alytheos after all believes that only mortals have the right to judge the lives of mortals.",
            EntryFamiliarity = 0
        };

        static JournalEntry Lexandri = new JournalEntry()
        {
            EntryName = "Lexandri",
            EntryDescription = "The goddess of knowledge, and history. Lexandri is the patron of philosophers and scholars, though she demands no worship. She acts as a chronicler, involving herself in the lives of those she believes will eventually become of historical significance- though she only appears as an advisor. She applies a level of romanticism to legends of the past, and often conjures spirits of heroes and figures of significance. While Lexandri is knowledgeable- she is not omniscient, and her love for knowledge extends into a love for the unknown and the discovery of it as well.",
            CreationEntryContextText = "Followers of Lexandri are often seekers of knowledge or admirers of history. Lexandri empowers objects of the pasts, artefacts and relics become legendary- and many of her followers seek them out. Many that follow her start museums and libraries, and the faithful are rewarded with magical servants from her domain to help maintain their collections.",
            EntryFamiliarity = 0
        };

        static JournalEntry Eradius = new JournalEntry()
        {
            EntryName = "Eradius",
            EntryDescription = "Lord of murder, chaos, and warfare. Despite the disconcerting domain- Worship of Eradius is typically more frowned upon rather than forbidden outright. Eradius doesn't espouse bloodshed for its own sake, he believes it to be the most vital means to ideal ends. Murder and warfare are necessities to shape your world into what one believes it ought to be- not based on matters of circumstance, but irreconcileable ideals. To Eradius, it takes true strength and wisdom to realize one's vision of a perfect world, and that it is folly to assume all that exist would naturally fall into said vision. While some worshippers of Eradius revel in the kill itself- it is by no means part of the faith, and none of Eradius' teachings explicitly advocate for extra-judicial murder",
            CreationEntryContextText = "Followers of Eradius are often perceived as ruthless or dangerous. Despite this, many of them are skilled in debate, oration and philosophy. Such a taboo faith needs quite the skill to convert others, and if the faith isn't portrayed in a positive light- there would be risk of nations outlawing it. Still, the majority that worship Eradius do fit the general assumption. Warriors and soldiers, imperialist monarchs, and even individuals that simply believe there are those that simply shouldn't live.",
            EntryFamiliarity = 0
        };

        static JournalEntry Asmodai = new JournalEntry()
        {
            EntryName = "Asmodai",
            EntryDescription = "Asmodai, the god of Law & Transaction. This god had no trace in history until mere years ago, when Akrosian lawyer 'Taipan Lewra' claimed to have been bestowed the secrets of law magic by this enigmatic patron. Supposedly- this deity came into existence with Akros' investigation into the contracts fiends used to bind souls. With the magic to conjure contracts in the hands of mortals, Asmodai manifested to reign as the judiciary over all arcane agreements.",
            CreationEntryContextText = "Followers of Asmodai are few and far between, as his existence is a recent matter after all. Still, few in Akros have taken to worshipping him alongside Alytheos. Most that do follow the study of Law Magic, often apprenticing under a Lewra or one of their apprentices. Lawyers and merchants especially find themselves attracted to Asmodai as a patron deity. A few also follow him due to their interest in the burgeoning field within the metaphysical and the arcane, some believing Law Magic to be only one avenue of strength from harnessing the power of civilization.",
            EntryFamiliarity = 0
        };

        static JournalEntry Thalessia = new JournalEntry()
        {
            EntryName = "Thalessia",
            EntryDescription = "Originally only a godess of the sea, Thalessia was prayed to for bountiful fishing expeditions and safe voyages. Over time, her influence spread even to landlocked regions- and she became more of a deity of exploration and the unknown. Thalessia's domain extended beyond the depths of the ocean- and into matters beyond comprehension. Thalessia could peer into worlds beyond what the other gods could see, and it's left her somewhat unintentillegible and hard to decipher",
            CreationEntryContextText = "Despite the more cryptic nature of Thalessia in recent times, those that worship her for safe travels and bounty in fishing still revere her. Some do fear that she retaliates against those that don't offer her tribute for their voyages though, and claim that leviathans of all sorts dwell in the oceans now due to her insanity. More dedicated worshippers seek to udnerstand her, attempting to acquire the forbidden knowledge and sight she possesses to see the world for what it truly is, maddening as it might be.",
            EntryFamiliarity = 0
        };

        static JournalEntry Lysia = new JournalEntry()
        {
            EntryName = "Lysia",
            EntryDescription = "Patron of the arts and experiences. Lysia is a complex deity to describe- it is a general assumption that Lysia accepts all truly inspired interpretations of themselves as a deity, and shifts themselves to appeal to their followers rather than the other way around. Certain sects believe Lysia to be a refined gentleman, a critique of all art that bids his followers to reach perfection. Others portray her as a manic woman- one that guides her followers into new expreiences with wild dances and hallucinogens for inspiration. In rare moments where Lysia reaches out to their followers, it's typically in appeal to whatever interpretation they valued most- if Lysia finds the interpretation worthy enough to include in their repertoire.",
            CreationEntryContextText = "Followers of Lysia are typically artists of one sort or another. Chefs view their plate as a canvas they paint in her honor, and musicians believe they can hear her play an accompaniment to their pieces. Those that follow her feel a sort of personal connection with her usually, they have an incomparable drive to chase the ephemeral spark of inspiration that exists in the ideals they attempt to capture in their art.",
            EntryFamiliarity = 0
        };

        static JournalEntry TheMortalSpirit = new JournalEntry()
        {
            EntryName = "The Mortal Spirit",
            EntryDescription = "Rather than a god, the mortal spirit encompasses the philosophy that gods ought not be the be all end all of the living. While a god's existence is difficult to deny, their influence and power can be fought. Believers in the mortal spirit simply believe in themselves, it is conviction in the power of one's own soul. Believing in the power of of oneself doesn't necessitate hatred or dismissal of other gods, and those that follow this philosophy may still worship- however in cases where those that believe still worship other gods, they would not put that god above themselves. To them, the world of man is of infinite value in comparison to the matters of gods above.",
            CreationEntryContextText = "Those that believe in the strength of the Mortal Spirit still follow certain rituals- though they are not dedicated to anyone in particular. They strive ot know themselves better, to empower their own philosophies and improve to the point where the influence of gods isn't necessary. Furthermore, some practice this 'faith' further to defend themselves from the influence of the gods and their followers- believing mortals ought to defend themselves from the wills of those that could never understand them.",
            EntryFamiliarity = 0
        };
    }
}
