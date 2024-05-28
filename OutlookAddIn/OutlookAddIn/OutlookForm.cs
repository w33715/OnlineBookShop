using System;

namespace OutlookAddIn
{
    partial class OutlookForm
    {
        #region Formularbereichsfactory 

        [Microsoft.Office.Tools.Outlook.FormRegionMessageClass(Microsoft.Office.Tools.Outlook.FormRegionMessageClassAttribute.Note)]
        [Microsoft.Office.Tools.Outlook.FormRegionName("OutlookAddIn.OutlookForm")]
        public partial class OutlookFormFactory
        {
            // Tritt ein, bevor der Formularbereich initialisiert wird.
            // Um die Anzeige des Formularbereichs zu verhindern, legen Sie "e.Cancel" auf "true" fest.
            // Verwenden Sie e.OutlookItem, um einen Verweis auf das aktuelle Outlook-Element abzurufen.
            private void OutlookFormFactory_FormRegionInitializing(object sender, Microsoft.Office.Tools.Outlook.FormRegionInitializingEventArgs e)
            {
            }
        }

        #endregion

        // Tritt ein, bevor der Formularbereich angezeigt wird.
        // Verwenden Sie this.OutlookItem, um einen Verweis auf das aktuelle Outlook-Element abzurufen.
        // Verwenden Sie this.OutlookFormRegion, um einen Verweis auf den Formularbereich abzurufen.
        private void OutlookForm_FormRegionShowing(object sender, System.EventArgs e)
        {
        }

        // Tritt ein, wenn der Formularbereich geschlossen wird.
        // Verwenden Sie this.OutlookItem, um einen Verweis auf das aktuelle Outlook-Element abzurufen.
        // Verwenden Sie this.OutlookFormRegion, um einen Verweis auf den Formularbereich abzurufen.
        private void OutlookForm_FormRegionClosed(object sender, System.EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OutlookForm_FormRegionClosed(sender, e);
        }
    }
}
