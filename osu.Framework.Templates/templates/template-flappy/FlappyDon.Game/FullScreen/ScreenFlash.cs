// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Graphics;
using osu.Framework.Graphics.Shapes;
using osuTK.Graphics;

namespace FlappyDon.Game
{
    /// <summary>
    /// A full-screen white flash used
    /// to indicate a collision with a pipe,
    /// or when the game scene resets after a
    /// game over.
    /// </summary>
    public class ScreenFlash : Box
    {
        public float FlashDuration = 30.0f;

        public ScreenFlash()
        {
            Colour = Color4.White;
            RelativeSizeAxes = Axes.Both;
            Alpha = 0.0f;
        }

        public void GameOverFlash()
        {
            this.FadeIn(FlashDuration).Then().FadeOut(500.0f);
        }

        public void ResetFlash()
        {
            this.FadeIn().Then().FadeOut(700.0f);
        }
    }
}
