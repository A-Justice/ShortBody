   M S B A M L   `   `   `  ���� D  @ShortBody, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ShortBody.PagesShortBody.Pages  W0clr-namespace:ShortBody.Resources.Helper_Methods"ShortBody.Resources.Helper_Methods  S.clr-namespace:ShortBody.Resources.UserControls ShortBody.Resources.UserControls  E'clr-namespace:ShortBody.ValueConvertersShortBody.ValueConverters  "    ShortBody.Pages.SupplierPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     /localclr-namespace:ShortBody.Pages     Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  9an0clr-namespace:ShortBody.Resources.Helper_Methods  8ctr.clr-namespace:ShortBody.Resources.UserControls  W SMaterialDesignThemes.Wpf, Version=1.2.0.31861, Culture=neutral, PublicKeyToken=null:md1http://materialdesigninxaml.net/winfx/xaml/themes  0cv'clr-namespace:ShortBody.ValueConverters  .���   � RowDefinitions  �� $
��Auto ��� $
��Auto ��� $��* ��� $��7 � � ColumnDefinitions �� $��* ��� $
��Auto �.+�� $��2��$��	20,5,20,5q�$��40��   MaterialDesignPaper#���   .+���  �� Orientation$ 
Horizontal=�$��Center=�$��5,0,5,0q�.+��� $��
SearchBy :��$��Center=�$��17(��� -   $��cboSearchBox��$��80��$��Center=�$��5,0,5,0q� �� Text �� *
SearchBy+@��� $	��All���� $
��Name���� $��Email���� -   $��txtSearchBox��$	��150��$��10,0,5,0q����� *SearchString+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=���   BoderlessButton#��[ $��17(�$��5,0,5,0q����� *SearchSupplierCommand+.��Search1   +ShortBody.Resources.UserControls.miniWindow  
������    
HeaderText$ All Suppliers��$��1��$��3��   CanClose .     Content �   �� $
��auto ��� $
��241* ��� $��10 �.+��� $ 
Horizontal=�  myDirtyWhite#��[ .+��� -   $��5q�	 � ToolTip$	 Add New Supplier��  b_Button#��[ .��"  FontAwesome.WPF.ImageAwesome  
   Icon$
 UserPlus=�$��20���� 
�������$��1��$��5,5,5,5q��� $��5,5,5,5q�#��[ ���� *DeleteSupplierCommand+.���� $ 
Horizontal=�$	 Delete Supplier��.+�  $
 Trash=�$��20��&   System.Windows.Controls.DataGrid  -   :   4ShortBody.Resources.Helper_Methods.DataGridExtension   HideAnnotatedColumns . 
���   �   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * $��2��   CanUserAddRows .  $��1��   CanUserReorderColumns .    CanUserResizeColumns .    CanUserResizeRows .     CanUserSortColumns . $��13(����� *AllSuppliers+$ PropertyChanged=�$ OneWay=�  -     Name$ AddSupplierWindow��1   +ShortBody.Resources.UserControls.miniWindow   Loaded$ AddSupplierWindow_Loaded��$��1��$��1��$ Add Supplier��$	��600��. �   �� $
��auto ��� $
��241* ��� $��10 �.+��� $ 
Horizontal=�#��[ .+��� $��10,5,5,5q�#��[ $	 Clear Boxes������ *
ClearBoxes+.��  $
 
PaintBrush=�$��20���� 
�������$��1��$��5,5,1,5q�� $��1��$��2��#���    � DataContext �� *NewSupplier+  �� $
��auto ��� $��* � �� $
��Auto ��� $��* ��� $
��Auto ��� $��* �.+���   tb#��[ $��5q� �� TextAlignment$ Center=����#CA5100$��4������ *Error+$ PropertyChanged=� ��  �� RelativeSource ��  �� AncestorType" >� �� Mode$ FindAncestor=� �� Path$ DataContext��� $��5q�$��1��.+��� #��[ $��Name :��$ Right=�$��10q�$��Center=��� #��[ $��	Address :��$ Right=�$��10q�$��Center=��� $��1��$��5q�$��1��.+��� $��	5,10,5,10q����� *Name+�� $��	5,10,5,10q����� *	Address+�� $��2��$��5q�$��1��.+��� #��[ $��Phone :��$ Right=�$��10q�$��Center=��� #��[ $��Email Adress :��$ Right=�$��10q�$��Center=��� $��3��$��5q�$��1��.+��� $��	5,10,5,10q����� *Phone+�� $��	5,10,5,10q����� *Email+�� $
��Save��$��50�� ��  �� " >�$ FindAncestor=�$ DataContext����� *SaveNewSupplierCommand+