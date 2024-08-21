namespace WinFormsRevisionPO2
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            Personne personne1 = new Personne("Doe", "John", 34);
            Personne personne2 = new Personne("Beauchamp", "Alice", 27);

            PersonnesListBox.Items.Add(personne1);
            PersonnesListBox.Items.Add(personne2);
        }



        private void buttonAugmenterAge_Click(object sender, EventArgs e)
        {
          

            int age = 1;
            if (PersonnesListBox.SelectedItems.Count > 0)
            {
                Personne personne = (Personne)PersonnesListBox.SelectedValue ;
                
              
                PersonnesListBox.Refresh();
                PersonnesListBox.Update();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une personne");
            }
        }

        private void PersonnesListBox_SelectedValueChanged(object sender, EventArgs e)
        {

        }
    }
}
