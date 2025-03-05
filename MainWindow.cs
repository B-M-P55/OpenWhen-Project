using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace OpenWhen
{
    public partial class MainWindow : Form
    {
        private List<Entry> entries = new List<Entry>();
        private readonly string[] categories = {
            "Happy", "Sad", "Lonely", "Stressed",
            "Miss someone", "Achievement", "Homesick",
            "Self-care", "Need fun"
        };
        private readonly string[] readingContent = {
           "Happiness is a gift—one that you deserve to embrace fully. Take a moment to celebrate the joy in your life, whether it’s a small victory or a big milestone. Let this happiness fill your heart and spill over into everything you do.>>>'Happiness is not something ready-made. It comes from your own actions.' — Dalai Lama",
           "I know this moment feels heavy, and your heart might be aching, but you’re not alone in this sadness. It’s okay to feel this way—it’s a natural part of being human. Allow yourself to process these emotions, and remember that brighter days are ahead. >>>'The way I see it, if you want the rainbow, you gotta put up with the rain.' — Dolly Parton",
           "Loneliness can feel endless, like an empty space that no one sees, but you’re stronger than you realize. This feeling doesn’t define you—it’s a signal to reach out, connect, or simply be kind to yourself. You’re not alone, even in your quietest moments. >>>'The sun is alone too, but it still shines.' — Unknown",
           "Breathe. Close your eyes for a moment, and let go of everything pressing on your mind. Stress can feel overwhelming, but you have the power to find peace within. Take small steps—maybe a walk, a deep breath, or a quiet moment—to ease the weight.>>> 'Almost everything will work again if you unplug it for a few minutes… including you.' — Anne Lamott",
           "Missing someone is proof that love exists beyond distance and time. It’s a beautiful ache, reminding you of the connection you share. Honor this feeling by holding their memory close, and know that they’re with you in spirit.>>> 'The pain of missing someone is a reminder of the love you shared.' — Unknown",
           "You did it! No matter how big or small this achievement is, it matters. Celebrate your hard work, resilience, and growth—it’s a testament to your strength and determination. Let this moment inspire you to keep reaching for your dreams.>>> 'The only limit to our realization of tomorrow is our doubts of today.' — Franklin D. Roosevelt",
           "Home isn’t just a place—it’s the people, the memories, the warmth you carry in your heart. Feeling homesick can be tough, but you carry that sense of belonging with you wherever you go. Let these memories comfort you until you’re back where you feel whole. >>>'You can go anywhere in the world, but nothing feels as good as coming home.' — Unknown",
           "You are important. You deserve rest, love, and care—not just from others, but from yourself. Practicing self-care isn’t selfish; it’s essential. Take time to nourish your mind, body, and soul, and let this moment be a reminder to prioritize you. >>>'You can’t pour from an empty cup. Take care of yourself first.' — Unknown",
           "Life doesn’t always have to be serious—sometimes, the best thing you can do is let go and just laugh. When you need fun or something hilarious, seek out joy in the little things—a funny movie, a silly joke, or a playful moment. Laughter can lift your spirits and brighten your day.>>> 'A day without laughter is a day wasted.' — Charlie Chaplin"
        };

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ShowCategoryForm(int categoryIndex)
        {
            if (categoryIndex >= 0 && categoryIndex < categories.Length)
            {
                var categoryForm = new CategoryForm(categories[categoryIndex], readingContent[categoryIndex], entries);
                categoryForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid category selected.");
            }
        }

        private void ShowEntriesForm()
        {
            var entriesForm = new EntriesForm(entries);
            entriesForm.ShowDialog();
        }

        private void btnHappy_Click(object sender, EventArgs e) => ShowCategoryForm(0);
        private void btnSad_Click(object sender, EventArgs e) => ShowCategoryForm(1);
        private void btnLonely_Click(object sender, EventArgs e) => ShowCategoryForm(2);
        private void btnStressed_Click(object sender, EventArgs e) => ShowCategoryForm(3);
        private void btnMissSomeone_Click(object sender, EventArgs e) => ShowCategoryForm(4);
        private void btnAchievement_Click(object sender, EventArgs e) => ShowCategoryForm(5);
        private void btnHomesick_Click(object sender, EventArgs e) => ShowCategoryForm(6);
        private void btnSelfCare_Click(object sender, EventArgs e) => ShowCategoryForm(7);
        private void btnNeedFun_Click(object sender, EventArgs e) => ShowCategoryForm(8);
        private void btnExit_Click(object sender, EventArgs e) => Application.Exit();
        private void btnViewEntries_Click(object sender, EventArgs e) => ShowEntriesForm();
    }
}