   M S B A M L   `   `   `  ���� D  @ShortBody, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ShortBody.PagesShortBody.Pages  S.clr-namespace:ShortBody.Resources.UserControls ShortBody.Resources.UserControls  W0clr-namespace:ShortBody.Resources.Helper_Methods"ShortBody.Resources.Helper_Methods  E'clr-namespace:ShortBody.ValueConvertersShortBody.ValueConverters       ShortBody.Pages.ClientPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     /localclr-namespace:ShortBody.Pages     Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  8ctr.clr-namespace:ShortBody.Resources.UserControls  9an0clr-namespace:ShortBody.Resources.Helper_Methods  0cv'clr-namespace:ShortBody.ValueConverters  W SMaterialDesignThemes.Wpf, Version=1.2.0.31861, Culture=neutral, PublicKeyToken=null:md1http://materialdesigninxaml.net/winfx/xaml/themes    N� ShowsNavigationUI  .  .���  � RowDefinitions �� $
��Auto ��� $
��Auto ��� $��* ��� $��7 � � ColumnDefinitions �� $��* ��� $
��Auto �.+�� $��2��$��	20,5,20,5q�$��40��   MaterialDesignPaper#���   .+���  �� Orientation$ 
Horizontal=�$��Center=�$��5,0,5,0q�.+��� $��
SearchBy :��$��Center=�$��17(��� -   $��cboSearchBox��$��80��$��Center=�$��5,0,5,0q� �� Text �� *
SearchBy+@��� $	��All���� $
��Name���� $��Email���� -   $��txtSearchBox��$	��150��$��10,0,5,0q����� *SearchString+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=���   BoderlessButton#��[ $��17(�$��5,0,5,0q����� *SearchClientCommand+.��Search1   +ShortBody.Resources.UserControls.miniWindow  
������    
HeaderText$ All Clients��$��1��$��3��   CanClose .  	   Content	 �  �� $
��auto ��� $
��241* �.+��� $ 
Horizontal=�  myDirtyWhite#��[ .+��� -   $��5q�
 � ToolTip$
 Add New Client��  b_Button#��[ .��
Add Client�� 
�������$��1��$��5,5,5,5q��� $��5,5,5,5q�#��[ ���� *DeleteClientCommand+.��Delete Client&   System.Windows.Controls.DataGrid  -   
���   �   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * $��1��:   4ShortBody.Resources.Helper_Methods.DataGridExtension   HideAnnotatedColumns .    CanUserReorderColumns .    CanUserResizeColumns .    CanUserAddRows .     CanUserResizeRows .     CanUserSortColumns . $��13(����� *
AllClients+$ PropertyChanged=�$ TwoWay=�  -     Name$ AddClientWindow��1   +ShortBody.Resources.UserControls.miniWindow   Loaded$ AddClientWindow_Loaded��$��1��$��1��$ 
Add Client��$	��600��.	 �  �� $
��auto ��� $
��241* ��� $��10 �.+��� $ 
Horizontal=�#��[ .+��� $��5,5,5,5q�#��[ $
 Clear Boxes������ *
ClearBoxes+.��"  FontAwesome.WPF.ImageAwesome     Icon$ 
PaintBrush=�$��20��$��3,0,0,0q�� $��1��$��2��#���    � DataContext �� *	NewClient+ �� $
��auto ��� $	��87* � �� $
��Auto ��� $��* ��� $
��Auto ��� $��* �.+���   tb#��[ $��5q� �� TextAlignment$ Center=����#CA5100$��4������ *Error+$ PropertyChanged=� ��  �� RelativeSource ��  �� AncestorType" N� �� Mode$ FindAncestor=� �� Path$ DataContext��� $��5q�$��1��.+��� #��[ $��Name :��$ Right=�$��10q�$��Center=��� #��[ $��	Address :��$ Right=�$��10q�$��Center=��� #��[ $��City :��$ Right=�$��10q�$��Center=��� $��1��$��5q�$��1��.+��� $��	5,10,5,10q����� *Name+�� $��	5,10,5,10q����� *	Address+�� $��	5,10,5,10q����� *City+�� $��2��$��5q�$��1��.+��� #��[ $��Phone :��$ Right=�$��10q�$��Center=��� #��[ $��Email Adress :��$ Right=�$��10q�$��Center=��� $��3��$��5q�$��1��.+��� $��	5,10,5,10q����� *Phone+�� $��	5,10,5,10q����� *Email+�� $
��Save��$��10q�$��70�� ��  �� " N�$ FindAncestor=�$ DataContext����� *SaveNewClientCommand+