using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWSoundBoard.Model
{
    public static class SoundManager
    {
        public static void GetAllSounds(ObservableCollection<Sound> sounds)
        {
            var allSounds = getSounds();
            sounds.Clear();
            /*
            foreach(var sound in allSounds)
            {
                sounds.Add(sound);
            }
            */
            allSounds.ForEach(sound => sounds.Add(sound));
        }

        public static void GetSoundsByCategory(ObservableCollection<Sound> sounds, SoundCategory category)
        {
            var allSounds = getSounds();

            /*
            var filteredSounds = new List<Sound>();
            foreach (var sound in allSounds)
            {
                if (sound.Category == category)
                {
                    filteredSounds.Add(sound);
                }
            }
            */

            var filteredSounds = allSounds.Where(sound => sound.Category == category).ToList();
            sounds.Clear();
            filteredSounds.ForEach(sound => sounds.Add(sound));
        }


        private static List<Sound> getSounds()
        {
            var sounds = new List<Sound>();
            sounds.Add(new Sound("Cat", SoundCategory.Animals));
            sounds.Add(new Sound("Cow", SoundCategory.Animals));
            sounds.Add(new Sound("Gun", SoundCategory.Cartoons));
            sounds.Add(new Sound("Spring", SoundCategory.Cartoons));
            sounds.Add(new Sound("Clock", SoundCategory.Taunts));
            sounds.Add(new Sound("LOL", SoundCategory.Taunts));
            sounds.Add(new Sound("Ship", SoundCategory.Warnings));
            sounds.Add(new Sound("Siren", SoundCategory.Warnings));

            return sounds;
        }

    }
}
