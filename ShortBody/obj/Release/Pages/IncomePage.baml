   M S B A M L   `   `   `  ���� D  @ShortBody, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:ShortBody.Resources.Helper_Methods"ShortBody.Resources.Helper_Methods  1clr-namespace:ShortBody.PagesShortBody.Pages  S.clr-namespace:ShortBody.Resources.UserControls ShortBody.Resources.UserControls  E'clr-namespace:ShortBody.ValueConvertersShortBody.ValueConverters       ShortBody.Pages.IncomePage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     ?an0clr-namespace:ShortBody.Resources.Helper_Methods     /localclr-namespace:ShortBody.Pages     >ctr.clr-namespace:ShortBody.Resources.UserControls     W SMaterialDesignThemes.Wpf, Version=1.2.0.31861, Culture=neutral, PublicKeyToken=null:md1http://materialdesigninxaml.net/winfx/xaml/themes  0cv'clr-namespace:ShortBody.ValueConverters  Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  .���   � RowDefinitions  �� $
��Auto ��� $
��Auto ��� $��* ��� $��7 � � ColumnDefinitions �� $��* ��� $
��Auto �.+�� $��2��$��	20,5,20,5q�$��40��   MaterialDesignPaper#���   .+���  �� Orientation$ 
Horizontal=�$��Center=�$��5,0,5,0q�.+��� $��
SearchBy :��$��Center=�$��17(��� -   $��cboSearchBox��$	��150��$��Center=�$��5,0,5,0q� �� Text �� *
SearchBy+@��� $	��All���� $��Cheque #���� $��Payee���� -   $��txtSearchBox��$	��150��$��10,0,5,0q����� *SearchString+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=���   BoderlessButton#��[ $��17(�$��5,0,5,0q����� *SearchIncomeCommand+.��Search1   +ShortBody.Resources.UserControls.miniWindow  
������    
HeaderText$ All Incomes��$��1��$��3��   CanClose .     Content �   �� $
��auto ��� $
��241* ��� $��10 �.+��� $ 
Horizontal=�  myDirtyWhite#��[ .+��� -   $��5q�	 � ToolTip$	 Add New Income��  b_Button#��[ .��"  FontAwesome.WPF.ImageAwesome  
   Icon$
 UserPlus=�$��20���� 
�������$��1��$��5,5,1,5q��� $��1,5,5,5q�#��[ ���� *DeleteIncomeCommand+.���� $ 
Horizontal=�$	 Delete Income��.+�  $
 Trash=�$��20���� 
�������$��1��$��5,5,1,5q��� -   $��1,5,5,5q�#��[ $��Income Statement��&   System.Windows.Controls.DataGrid  -   ��.     AutoGenerateColumns .  
���   �   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * $��1��$��2��   CanUserAddRows .     CanUserReorderColumns .    CanUserResizeColumns .    CanUserResizeRows .     CanUserSortColumns . $��13(����� *
AllIncomes+$ PropertyChanged=�$ OneWay=�   Columns 9  3MaterialDesignThemes.Wpf.MaterialDataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$
 Date��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *Date+ �� 	Converter -  'ShortBody.ValueConverters.DateFormatter    $ Payee�� �� *Payee+  $ ChequeNumber�� �� *ChequeNumber+  $ Amount�� �� *Amount+ -	   'ShortBody.ValueConverters.DToSConverter	    -     Name$ AddIncomeWindow��1
   +ShortBody.Resources.UserControls.miniWindow 
  Loaded$ AddIncomeWindow_Loaded��$��1��$��1��$ Add New Income��$	��600��. �   �� $
��auto ��� $
��241* ��� $��10 �.+��� $ 
Horizontal=�#��[ .+��� $��10,5,5,5q�#��[ $	 Clear Boxes������ *
ClearBoxes+.���� $ 
Horizontal=�.+�  $
 
PaintBrush=�$��20���� 
�������$��1��$��5,5,1,5q�� $��1��$��2��#���    � DataContext �� *	NewIncome+  �� $��8* ��� $	��55* � �� $
��Auto ��� $��* ��� $
��Auto ��� $��* �.+���   tb#��[ $��5q� �� TextAlignment$ Center=����#CA5100$��4������ *Error+$ PropertyChanged=� ��  �� RelativeSource ��  �� AncestorType" >� �� Mode$ FindAncestor=� �� Path$ DataContext��� $��5q�$��1��.+��� #��[ $��Payee :��$ Right=�$��10q�$��Center=��� $��1��$��5q�$��1��.+��� $��	5,10,5,10q����� *Payee+�� $��2��$��5q�$��1��.+��� #��[ $��Cheque Number :��$ Right=�$��10q�$��Center=��� #��[ $��Amount :��$ Right=�$��10q�$��Center=��� $��3��$��5q�$��1��.+��� $��	5,10,5,10q����� *ChequeNumber+�� $��	5,10,5,10q����� *Amount+�� $
��Save��$��50�� ��  �� "  $ FindAncestor=�$ DataContext����� *SaveIncomeCommand+