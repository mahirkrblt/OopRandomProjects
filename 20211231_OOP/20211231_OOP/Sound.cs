using System.Media;

namespace _20211231_OOP
{
    class Sound
    {
        //Must using System.Media library.
        //Type the file extension when importing the instance.
        
        public SoundPlayer Play(string path)
        {
            SoundPlayer sound = new SoundPlayer();
            sound.SoundLocation = path;
            sound.Play();
            return sound;
        }

        public SoundPlayer PlaySync(string path)
        {
            SoundPlayer sound = new SoundPlayer();
            sound.SoundLocation = @"..\..\" + path;
            sound.PlaySync();
            return sound;
        }

        public SoundPlayer PlayLooping(string path)
        {
            SoundPlayer sound = new SoundPlayer();
            sound.SoundLocation = @"..\..\" + path;
            sound.PlayLooping();
            return sound;
        }
    }
}
