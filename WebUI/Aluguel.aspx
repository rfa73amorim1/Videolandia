<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Aluguel.aspx.cs" Inherits="WebUI.Aluguel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Viodeolândia - Locação</h2>
    <h3>Página de locação de filme(s) </h3>

    <div class="form-horizontal">

          <f class="text-sucess">
           <asp:Label ID="lblMensagem" runat="server"></asp:Label>

          </f>
         <hr/>

        <div class="form-group">
             &nbsp;&nbsp;
            <asp:Image ID="imgFilme" runat="server" />
            
            <br />
                        
            </div>
        <div class="form-group">
            <asp:Label ID="lblDtLocacao" runat="server" Text="Data da Locação" CssClass="col-md-2 control-label"></asp:Label>
            <asp:TextBox ID="txtDtLocacao" runat="server" type="date" CssClass="col-md-5 form-control" style="left: 0px; top: 0px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblDtDevolucao" runat="server" Text="Data da Devolução" CssClass="col-md-2 control-label"></asp:Label>
            <asp:TextBox ID="txtDtDevolucao" runat="server" type="date" CssClass="col-md-5 form-control" style="left: 1px; top: 0px"></asp:TextBox>
             &nbsp;&nbsp;
            <asp:CompareValidator ID="cvDtDevolucao" runat="server" ErrorMessage="Data menor que a data da locação" ControlToCompare="txtDtLocacao" ControlToValidate="txtDtDevolucao" ForeColor="Red" Operator="GreaterThanEqual" Type="Date"></asp:CompareValidator>
        </div>

        <div class="form-group">
             <div class="col-md-offset-2 col-md-02">
                 <asp:Button ID="Button1" runat="server" Text="Alugar" CssClass="btn btn-default" OnClick="btnAlugar_Click" />

            

                 &nbsp;&nbsp;&nbsp;
                 <asp:LinkButton ID="lkbVoltar" runat="server" PostBackUrl="~/Default.aspx">Voltar</asp:LinkButton>

            

                 <br />

            <br />

                 <asp:GridView ID="grvAlugar" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical">
                <AlternatingRowStyle BackColor="#CCCCCC" />
                <Columns>
                    <asp:BoundField DataField="idFilme" HeaderText="Código">
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Top" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Titulo" HeaderText="Título">
                    <ItemStyle VerticalAlign="Top" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Genero" HeaderText="Gênero">
                    <ItemStyle VerticalAlign="Top" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Ano" HeaderText="Ano">
                    <ItemStyle VerticalAlign="Top" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Ator" HeaderText="Ator">
                    <ItemStyle VerticalAlign="Top" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Diretor" HeaderText="Diretor">
                    <ItemStyle VerticalAlign="Top" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Tipo" HeaderText="Tipo">
                    <ItemStyle VerticalAlign="Top" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Tecnologia" HeaderText="Tecnologia">
                    <ItemStyle VerticalAlign="Top" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Preco" HeaderText="Preço R$">
                    <ItemStyle VerticalAlign="Top" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Status" HeaderText="Status">
                    <ItemStyle VerticalAlign="Top" />
                    </asp:BoundField>
                </Columns>
                <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="Gray" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#383838" />

                 </asp:GridView>

                 <div class="form-group">
                     <asp:Label ID="lblData" runat="server" CssClass="col-md-2 control-label"></asp:Label>
                 </div>

             </div>

        </div>

    </div>

</asp:Content>
