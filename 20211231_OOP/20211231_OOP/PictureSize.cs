using System.Windows.Forms;

namespace _20211231_OOP
{
    class PictureSize
    {
        public PictureBox Picture(PictureBox pictureName, int pictureSize)
        {
            pictureName.Height = pictureSize;
            pictureName.Width = pictureSize;
            return pictureName;
        }

        public PictureBox Picture(PictureBox pictureName, int pictureHeight,int pictureWidth)
        {
            pictureName.Height = pictureHeight;
            pictureName.Width = pictureWidth;
            return pictureName;
        }
    }
}
