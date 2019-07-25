using System.Collections;
using System.Windows.Forms;

namespace SnakeGame
{
    /// <summary>
    /// Input class
    /// </summary>
    internal class Input
    {
        //Load list of available Keyboard buttons
        /// <summary>
        /// The key table
        /// </summary>
        private static Hashtable keyTable = new Hashtable();

        //Perform a check to see if a particular button is pressed.
        /// <summary>
        /// Keys the pressed.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns></returns>
        public static bool KeyPressed(Keys key)
        {
            if (keyTable[key] == null)
            {
                return false;
            }

            return (bool)keyTable[key];
        }

        //Detect if a keyboard button is pressed
        /// <summary>
        /// Changes the state.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="state">if set to <c>true</c> [state].</param>
        public static void ChangeState(Keys key, bool state)
        {
            keyTable[key] = state;
        }
    }
}