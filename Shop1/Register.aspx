<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Shop1.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="defaultContent" runat="server">

        <a name="Rejestracja"></a>
                <h1>Rejestracja</h1>
          <p><asp:Label ID="LabelLogin" runat="server" Text="Login:"></asp:Label></p>
    <p>
                      <asp:TextBox ID="TextBoxLogin" runat="server"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxLogin" ErrorMessage="Pole Login jest wymagane!" ValidationGroup="RegisterGroup">*</asp:RequiredFieldValidator>
                      </p>
          <p><asp:Label ID="LabelPassword" runat="server" Text="Has&#322;o:"></asp:Label></p>
    <p>
                      <asp:TextBox ID="TextBoxPassword" runat="server" TextMode="Password"></asp:TextBox>
                      <br />
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBoxPassword" ErrorMessage="Pole Has&#322;o jest wymagane!" ValidationGroup="RegisterGroup"></asp:RequiredFieldValidator>
                      &nbsp;<br />
                      <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBoxPassword" ErrorMessage="Hasło musi składać się z conajmniej jednej litery i jednej cyfry!" ValidationExpression="[0-9*]+[a-zA-ZąćęłńóśźżĄĆĘŁŃÓŚŹŻ*]+|[a-zA-ZąćęłńóśźżĄĆĘŁŃÓŚŹŻ*]+[0-9] +" ValidationGroup="RegisterGroup"></asp:RegularExpressionValidator>
                      <br />
                      <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="TextBoxPassword" ErrorMessage="Hasło powinno składać sie z conajmniej 8 znaków!" ValidationExpression="[0-9a-zA-ZąćęłńóśźżĄĆĘŁŃÓŚŹŻ]{8,}" ValidationGroup="RegisterGroup"></asp:RegularExpressionValidator>
                      </p>
          <p><asp:Label ID="LabelRepeatPassword" runat="server" Text="Powtórz has&#322;o:"></asp:Label></p>
    <p>
                      <asp:TextBox ID="TextBoxRepeatPassword" runat="server" TextMode="Password"></asp:TextBox>
                      <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBoxPassword" ControlToValidate="TextBoxRepeatPassword" ErrorMessage="Has&#322;a nie s&#261; takie same." EnableClientScript="False" ValidationGroup="RegisterGroup"></asp:CompareValidator>
                      </p>
          <p><asp:Label ID="LabelEmail" runat="server" Text="E-mail:"></asp:Label></p>
    <p>
                      <asp:TextBox ID="TextBoxEmail" runat="server" TextMode="Email"></asp:TextBox>
                      <br />
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBoxEmail"  ErrorMessage="Pole E-mail jest wymagane!" ValidationGroup="RegisterGroup"></asp:RequiredFieldValidator>
                      <br />
                      <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBoxEmail" ErrorMessage="Nieprawidłowy adres e-mail!" ValidationExpression="^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$" ViewStateMode="Enabled"></asp:RegularExpressionValidator>
                      </p>
                  <p>
                  <asp:Label ID="LabelName" runat="server" Text="Imie"></asp:Label>:</p>
    <p>
                      <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBoxName" ErrorMessage="Pole Imi&#281; jest wymagane!" ValidationGroup="RegisterGroup"></asp:RequiredFieldValidator>
                      </p>
                 <p> <asp:Label ID="LabelLastName" runat="server" Text="Nazwisko:"></asp:Label></p>
    <p> 
                      <asp:TextBox ID="TextBoxLastName" runat="server" Height="16px" Width="118px"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBoxLastName" ErrorMessage="Pole Nazwisko jest wymagane!" ValidationGroup="RegisterGroup"></asp:RequiredFieldValidator>
                      </p>
<p> 
                      <asp:Label ID="LabelCity" runat="server" Text="Miasto"></asp:Label>
                      </p>
<p> 
                      <asp:TextBox ID="TextBoxCity" runat="server"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBoxCity" ErrorMessage="Pole Miasto jest wymagane!" ValidationGroup="RegisterGroup"></asp:RequiredFieldValidator>
                      </p>
<p> 
                      <asp:Label ID="LabelAddress" runat="server" Text="Adres"></asp:Label>
                      </p>
<p> 
                      <asp:TextBox ID="TextBoxAddress" runat="server"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TextBoxAddress" ErrorMessage="Pole Adres jest wymagane!" ValidationGroup="RegisterGroup"></asp:RequiredFieldValidator>
                      </p>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="RegisterGroup" />
        <p>
            <asp:Label ID="LabelAccept" runat="server" Text="Akceptuj&#281; regulamin sklepu:"></asp:Label>&nbsp; <asp:CheckBox ID="CheckBoxAccept" runat="server" />
        <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="Prosz&#281; zaakceptowa&#263; regulamin." OnServerValidate="CustomValidator1_ServerValidate" ValidationGroup="RegisterGroup"></asp:CustomValidator>
</p>
    <p>
        <asp:Button ID="ButtonAccept" runat="server" Height="26px" Text="Potwierd&#378;" OnClick="ButtonAccept_Click" ValidationGroup="RegisterGroup" />
    </p>
</asp:Content>
