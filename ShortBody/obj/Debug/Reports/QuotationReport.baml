   M S B A M L   `   `   `  ����D  @ShortBody, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ShortBody.ReportsShortBody.Reports  5   	   W SMaterialDesignThemes.Wpf, Version=1.2.0.31861, Culture=neutral, PublicKeyToken=nulleHclr-namespace:MaterialDesignThemes.Wpf;assembly=MaterialDesignThemes.WpfMaterialDesignThemes.Wpf 5   	   {Sclr-namespace:MaterialDesignThemes.Wpf.Converters;assembly=MaterialDesignThemes.Wpf#MaterialDesignThemes.Wpf.Converters 5      E'clr-namespace:ShortBody.ValueConvertersShortBody.ValueConverters  5	   	   W0clr-namespace:ShortBody.Resources.Helper_Methods"ShortBody.Resources.Helper_Methods  5
      '    !ShortBody.Reports.QuotationReport   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:ShortBody.Reports     5   	   XwpfHclr-namespace:MaterialDesignThemes.Wpf;assembly=MaterialDesignThemes.Wpf     5   	   j
convertersSclr-namespace:MaterialDesignThemes.Wpf.Converters;assembly=MaterialDesignThemes.Wpf     5      6cv'clr-namespace:ShortBody.ValueConverters     5	   	   ?an0clr-namespace:ShortBody.Resources.Helper_Methods     5
      Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5      :md1http://materialdesigninxaml.net/winfx/xaml/themes  5      -   5          � WindowStartupLocation$  CenterScreen=�5   	   $	��800��5      $	��795��6    � Icon$4 ./ShortBody;component/Resources/Images/icon.ico��6,    � Title$ QuotationReport��5   	    � 	Resources 5      *  $System.Windows.Controls.DataGridCell �� 
TargetType �� Property �� Value �� 
TargetType J� SnapsToDevicePixels	 �� Triggers
 P� Property P� Value   MaterialDesignTextBoxBorder ]� 
Conditions �� Property �� Value  MaterialDesignSelection  MaterialDesignBody  MaterialDesignTextBox �� BasedOn ��Name �� Padding ��Name � UseLayoutRounding(  "MaterialDesignThemes.Wpf.SmartHint  Name   Hint �� Path �� RelativeSource   	HintProxyB  <MaterialDesignThemes.Wpf.Converters.HintProxyFabricConverter   Instance �� 	Converter   HintOpacity   UseFloating   FloatingScale   FloatingOffset(  "MaterialDesignThemes.Wpf.Underline  Name  �� Triggers! �� 
SourceName" �� 
TargetName  PrimaryHueMidBrush)  #MaterialDesignThemes.Wpf.HintAssist  ValidationErrorBrush��%;  '        '�� �    7  �� 5   
   "  6   .�5      ��  � ��$ 1q�6(   �� 5       � ��
 ���� 6+   �� 5       � ��
 ���� 6,   �� 5       � ��$ 0q�6'   �� 5       � �� 5      �� 5      "  6&   .R�5      �� #��z��6!   #��z��6M   #��z��6�    . ._�5      �� $��
MidTextBox��6/   # z 6A   #��z��5   +   $��Center=�6N   $��Center=�5   /   $��50��6L   5       5!      5$      	 5'      P� 5(      
 �@J�IsKeyboardFocusWithin . . �5)      ��  � ��# �   64   5*      ]� 5+       5,      �� 5-       �@ 
IsSelected . 6:   �� 5.       �@��IsSelectionActive .  6J   ./�50      ��  � ��# �  63   51      ]� 52       53      �� 54       �@ 
IsSelected . 6:   �� 55       �@��IsSelectionActive . 6J   ./�57      ��  � ��# �  63   58      P� 59      
 � {� .  . �5:      ��  �@J�Opacity$	 .56Q�60   5;      5=      �� 5@   
   " ��6   8   .�5A      ��  � ��$ 11(�6)   �� 5B       � ��$ 0q�60   �� 5C       � ��$ Arial)�6+   �� 5D       � ��$ 0q�6(   �� 5E       � ��$ 0q�6'   �� 5F       � �� 5G      �� 5H      " ��6&   .R�5I      � .+�5J      �� $ border��6%   #��z��5K   !   #��z��5L   !   #��z��5M   !    . $ 0q�5O   !   ._�5P   "   � #��z��6'   #��z��5Q   #   #��z��5R   #   .+�5S   &   �� $ PART_ContentHost��63   |�.  $��Hidden=�5T   /   $��Hidden=�6V   # z 5U   /   # z 5V   /     5X   &   $
 Hint��64   #��z��5[   0    5Y   0   �� $ (wpf:HintAssist.Hint)� �� *TemplatedParent+ 5Z   0   ��  �� *TemplatedParent+# Z  5\   0   �� $" (wpf:HintAssist.HintOpacity)� �� *TemplatedParent+ 5]   0   �� $! (wpf:HintAssist.IsFloating)� �� *TemplatedParent+ 5^   0   �� $$ (wpf:HintAssist.FloatingScale)� �� *TemplatedParent+ 5_   0   �� $% (wpf:HintAssist.FloatingOffset)� �� *TemplatedParent+5a   #   5b        5c      $ 	Underline��6,   y�6?   �� $0 *(wpf:TextFieldAssist.DecorationVisibility)� �� *TemplatedParent+5d        5e      ]� 5f       5g   "   �� 5h   &   $
! Hint��60    �@ IsContentNullOrEmpty .  6b   �� 5i   &    �@J�IsKeyboardFocused . 6M   ./�5k   "   �� $
" Hint��6)   # �  6Q    � ���� 5l   "   $
" Hint��6)    �@ HintOpacity$ 1Q�6R   5m      P� 5n      
 �@ 
IsFloating . . �5o   "   �� $" border��6)    � ��$ 0 12 0 0q�6O   5p      P� 5q      
 � {� .  . �5r   "   �� $" border��6<    �@J�Opacity$
 0.56Q�6P   5s      P� 5t      
 �@J�IsMouseOver . . �5u   "   �� # �  6@    � ��5v      P� 5w      
 �@J�IsKeyboardFocused . . �5x   "   �� $" 	Underline��6)    �@ IsActive . 6T   5y      P� 5z      
 �@=�HasError . . �5{   "   �� # �  6@    � ���� 5|   "   $" 	Underline��6)   # �  6V    � ��5}      5      5�      5�      5�      .��5�      � -   5        $��MainGrid��5�      $	��800��6   # � RowDefinitions# 5�   
   �� 5�      $
��Auto �6   �� 5�      $��* �6   .+�5�   
   �� -   5        $��TopPanel��5�   .   $ �� Orientation$$ 
Horizontal=�6   .+�5�      �� -   5        $��5q�5�   *   .��5�      "  FontAwesome.WPF.ImageAwesome  %   Icon$% Print=�6"   $��40��6/   $��5q�6:   & � ToolTip$& Print��6E   5�      �� 5�      -   5        $��5q�5�      .��5�        $% search=�6"   $��40��60   $��5q�6;   $& PrintPreview��6F   5�      5�      ,� 5�   
   -   5        $��Document��5�   W   $��1��6#   .��5�      /� -   5        ' �Name$' FD��5�   -   ( /� ColumnWidth$	( 500��6   .T�5�      �� ) �� Margin$) 0,0,0,0q�6#   .r�5�      � # 5�      �� 5�      $
��Auto �6,   �� 5�      $
��auto �6,   �� 5�      $
��Auto �6,   �� 5�      $
��auto �6,   �� 5�      $
��auto �6,   �� 5�      $
��auto �6,   �� 5�      $
��auto �6,   .+�5�      �� $$ 
Horizontal=�6%   $��Center=�6>   $��0,0,0,5q�5�   %   * � DataContext* 5�      �� *CurrentCompany+.+�5�      �� $	��100��6$   $	��100��61   $��0,0,20,0q�6=   ��6O   �� *Logo+ 4   .ShortBody.ValueConverters.ByteToImageConverter  �� 5�      $��20,0,0,0q�6)   .+�5�   "   �� $��20��6@   $��	ExtraBold"�5�   *   $��	20,0,20,5q�6A   ��5�   *   �� *Name+5�   A   �� 5�   "   $$ 
Horizontal=�6-   .+�5�   &   �� $��5,0,0,0q�61   .+�5�   *   �� $��	Address :��62   $��13(�6C   + �� TextAlignment$+ Right=�6Q   �� 5�   *   $��Phone :��62   $��13(�6A   $+ Right=�6O   �� 5�   *   $��Email :��62   $��13(�6A   $+ Right=�6O   5�   '   �� 5�   &   $��5,0,0,0q�61   $	��200��6B   .+�5�   *   �� $��13(�62   ��6@   �� *	Address+, �� UpdateSourceTrigger$, PropertyChanged=��� 5�   *   $��13(�62   ��6@   �� *Phone+$, PropertyChanged=��� 5�   *   $��13(�62   ��6@   �� *Email+$, PropertyChanged=�5�   '   5�   #   5�      5�      � 5�      $��1��6   $��5,1,5,1q�6,   - � ColumnDefinitions- 5�      �� 5�   "   $��* �63   �� 5�   "   $
��Auto �63   �� 5�   "   $��* �63   .+�5�      �� $��Center=�6)   $��	20,0,20,0q�6D   .+�5�   "   �� $��5��6,   
����  �67   �� 5�   "   $��2��6,   
����� �67   5�      �� 5�      $��1��6&   $��	QUOTATION��66   $��Italic$�5�   &   $��20(�69   $��Center=�5�      $��	ExtraBold"�5�      �� 5�      $��2��6)   $��Center=�69   $��	20,0,20,0q�5�      .+�5�   "   �� $��5��6,   
����  �67   �� 5�   "   $��2��6,   
����� �67   5�      5�      � 5�      $��2��6   - 5�      �� 5�   "   $
��1.3* �63   �� 5�   "   $��* �63   .+�5�      �� $��	10,0,10,0q�6'   $��Customer��6:     NormalGroupBox#��[ 5�   (   * 5�   '   �� *SelectedClient+.��5�   "   �� $$ 
Horizontal=�6-   .+�5�   &   �� $��5,0,0,0q�61   .+�5�   *   �� $��Name :��62   $+ Right=�6@   �� 5�   *   $��	Address :��62   $+ Right=�6C   �� 5�   *   $��City :��62   $+ Right=�6@   �� 5�   *   $��Requester :��62   $+ Right=�6E   5�   '   �� 5�   &   $��5,0,0,0q�61   $	��250��6B   .+�5�   *   �� $
+ Left=�6l   ��62   �� *Name+$, PropertyChanged=�6l   �� 5�   *   $
+ Left=�6o   ��62   �� *	Address+$, PropertyChanged=�6o   �� 5�   *   $
+ Left=�6l   ��62   �� *City+$, PropertyChanged=�6l   �� 5�   *   $
+ Left=�6�   * 62   ��  �� . �� AncestorType". �/ �� Mode$/ FindAncestor=�$ DataContext���6�   �� *SelectedQuotation.Requester+$, PropertyChanged=�6�   5�   '   5�   #   5�      �� 5�      $��1��6'   #��[ 5�   '   $�� ��6O   * 5�   8   �� *SelectedQuotation+.��5�   "   �� $$ 
Horizontal=�6-   .+�5�   &   �� $��5,0,0,0q�61   .+�5�   *   �� $��	Quote # :��62   $+ Right=�6C   �� 5�   *   $��LPO # :��62   $+ Right=�6A   �� 5�   *   $��Date :��62   $+ Right=�6@   �� 5�   *   $��Work Order # :��62   $+ Right=�6H   5�   '   �� 5�   &   $��5,0,0,0q�61   $	��120��6B   .+�5�   *   �� ��62   �� *QuoteNumber+�� 5�   *   ��63   �� *LPO+�� 5�   *   ��62   �� *	QuoteDate+$, PropertyChanged=�0 �� Mode$0 TwoWay=� -  'ShortBody.ValueConverters.DateFormatter  �� 5�   *   ��62   �� *WOD+$, PropertyChanged=�$0 TwoWay=�5�   '   5�   #   5�      5�      � 5�      $��3��6   - 5�      �� 5   "   $��* �63   �� 5  "   $
��auto �63   .+�5     �� $��Center=�6�   $
��Bold"�6�   $��5q�6�   1 �� TextWrapping$
1 Wrap=�6�   $��15(�6�   * 6&   �� *SelectedQuotation+��6P   �� *ServiceWanted+$, PropertyChanged=�6�   �� 5     -   5        $��helperPanel��5  n   $��1��6)   $$ 
Horizontal=�69   $��Right=�6R   $��0,0,20,0q�5  %   * 5  -   ��  �� ". �$/ FindAncestor=�$ DataContext�.+�5  "   �� -	   5        $��btnFsIncrease��5  F   $& Increase Font Size��6)   .��5
  &     $% CaretUp=�66   $��10��6E   $& Bolden��6P   5  #   �� 5  "   -
   5        $��btnFsDecrease��5  F   $& Decrease Font Size��6)   .��5  &     $% 	CaretDown=�66   $��10��6G   $& Bolden��6R   5  #   �� 5  "   -   5        $��btnClearFormatting��5  H   $& Clear All Formatting��6)   .��5  &     $% 
PaintBrush=�66   $��10��6H   $& Bolden��6S   5  #   �� 5  "   -   5        $��	btnBolden��5  )   .��5  &     $
% Bold=�66   $��10��6B   $& Bolden��6M   5  #   �� 5  "   -   5        $��btnUnderline��5  *   .��5  &     $% 	Underline=�66   $��10��6G   $& 	Underline��6R   5  #   �� 5  "   -   5        $��btnItalicize��5  =   $& 	Italicize��6)   .��5  &     $% Italic=�66   $��10��6D   5   #   �� 5"  "   -   5        $��btnDeleteItem��5"  O   $& Delete Selected Item��5#  -   ��5"  )   �� *DeleteItemCommand+.��5$  &     $% Trash=�66   $��10��6C   5%  #   5&     5'     �� 5)     $��4��6!   * 5*  !   �� *SelectedQuotation+$, PropertyChanged=�$0 TwoWay=�._�5+     � # 5,  "   �� 5-  &   $
��auto �64   �� 5.  &   $	��560 �64   �� 5/  &   $
��auto �64   .+�53  "   &	   System.Windows.Controls.DataGrid	  -   5        $��ItemsDataGrid��53  +   $��1��6A   $	��Top=�6N   
���   �$��1q�6z   $��Hidden=�54  +   $	��550��6]   $	��550��6m     QuoteItemsRow2 	  RowStyle#2 [ 56  +    	 Smoke3 	  AlternatingRowBackground#3 [ 57  '   4 �� AlternationCount$4 2��6Y   :
   4ShortBody.Resources.Helper_Methods.DataGridExtension5 
  HideAnnotatedColumns5 . 6 	  AutoGenerateColumns6 .  7 	  CanUserReorderColumns7 .  
�������$��10(�5:  W   ��58  '   �� *Items+$, PropertyChanged=�$0 TwoWay=�8 	  Columns8 5<  &   0  *System.Windows.Controls.DataGridTextColumn  5=  *   ,  &System.Windows.Controls.DataGridColumn9   Header$	9 QTY��6>   :   Width5  /System.Windows.Controls.DataGridLengthConverter$	: 100 5>  :   1  +System.Windows.Controls.DataGridBoundColumn;   Binding; 5=  K   �� *QTY+$, PropertyChanged=�$0 TwoWay=�5>  :     5?  *   $9 Description��6=    	 elementStyle<   ElementStyle#< [	 6�    
 editingElementStyle=   EditingElementStyle#= [
 6�   $	: 340 5@  9   ; 5?  R   �� *Description+$, PropertyChanged=�$0 TwoWay=�5@  9     5A  *   $9 UnitCost��6=   $	: 100 5B  9   ; 5A  O   �� *
UnitCost+$, PropertyChanged=�$0 TwoWay=�5B  9     5C  *   $9 	TotalCost��6=   $	: 100 5D  9   ; 5C  P   �� *	TotalCost+$, PropertyChanged=�$0 TwoWay=�5D  9   5H  #   5M     5N     � 5Q     $��5��6   * 6,   �� *SelectedQuotation+- 5R     �� 5S  "   $��* �63   �� 5T  "   $
��auto �63   �� 5U  "   $	��200 �63   # 5X     �� 5Y  "   $
��auto �60   �� 5Z  "   $
��auto �60   �� 5[  "   $
��auto �60   �� 5\  "   $
��auto �60   �� 5]  "   $
��auto �60   �� 5^  "   $
��auto �60   �� 5_  "   $
��auto �60   �� 5`  "   $
��auto �60   �� 5a  "   $
��auto �60   �� 5b  "   $
��auto �60   .+�5e     �� $��1��6&   $	��110��67   $��14(�6C   $��Sub-Total( GHS ) :��5f  (   $+ Right=�6B   �� 5h     $��1��6&   $��1��66   $	��110��6C   $��14(�6O   $��Vat + Nhil % :��5i  (   $+ Right=�6>   �� 5k     $��1��6&   $��3��66   $	��110��6C   $��15(�6O   $
��Bold"�5l  &   $��Total ( GHS ) :��5m  (   $+ Right=�6?   �� 5o     $�� Vat Value : ��6&   $��1��6;   $��2��6K   $��14(�6X   $+ Right=�6f   $��5,0,0,0q�6}   �� 5p     -   5        $��tbVatAmount��5p  R   $��2��6&   $��14(�66   $��2��6E   $
+ Left=�5r  *   ��5q  *   �� *
VatValue+$, PropertyChanged=�$0 TwoWay=� -   'ShortBody.ValueConverters.DToSConverter  5r  *   �� 5t     -   5        $��
tbSubTotal��5t  7   $��2��6&   $
+ Left=�5u  &   $��14(�6;   ��5t  I   �� *Amount+$, PropertyChanged=�$0 TwoWay=�   5u  ;   �� 5x     -   5        $��tbVat��5x  '   $��14(�64   $��2��6C   $��1��6T   $
+ Left=�5z  +   ��5x  a   �� *
Vat_Nhil+$, PropertyChanged=�$0 TwoWay=�5z  +   �� 5~     -   5        $��tbTotal��5�  8   $��2��5~  &   $��3��67   $��15(�6D   > �� TextDecorations$> 	Underline{�5  &   $
��Bold"�5�  &   ���#CA5100$
+ Left=�6\   ��5�  &   �� *TotalAmount+$, PropertyChanged=�$0 TwoWay=�   �� 5�     $��4��6&   $��1��63   $��2��6C   $+ Center=�5�  &   ��6=   �� *Others+? �� FallbackValue$'? !Price Excludes VAT + NHIL charges���� 5�     $��1,1,1,1q�6&   $
1 Wrap=�6^   $	��250��6r     NormalTextBox#��[ 5�  &   $��5��5�  %   $��1��62   $��2��6B   $��30��6V   ��5�  @   �� *Miscellenous+5�  V   �� 5�     $��6��6&   $��1��63   $��Issued By :��6C   �� 5�     $��5��6&   $��2��63   $��0,39.97,0,0.98q�5�  p   $��2��6�   ��6&   �� *
IssuedBy+$, PropertyChanged=�$0 TwoWay=�6�   �� 5�     $��Bank Acc Details��6'   
���   �$	��350��6U   $��5��5�  #   $��5q�64   #��[ 6?   * 5�  '   ��  �� ". �$ DataContext�.��5�  "   � * 6'   �� *CompanyAccDetails+$, PropertyChanged=�$0 TwoWay=�- 5�  &   �� 5�  *   $��* �6;   �� 5�  *   $��* �6;   �� 5�  *   $
��Auto �6;   .+�5�  &   �� $��	10,0,10,0q�61   .+�5�  *   �� $$ 
Horizontal=�65   $��Right=�6N   .+�5�  .   �� $��Account Name :��66   5�  +   �� 5�  *   $$ 
Horizontal=�65   $��Right=�6N   .+�5�  .   �� $��Bank Name :��66   5�  +   �� 5�  *   $��Account Number :��62   $��Right=�6J   �� 5�  *   $��Bank Branch :��62   $��Right=�6G   5�  '   �� 5�  &   $��	10,0,10,0q�61   $��1��6D   $	��100��6T   .+�5�  *   �� ��62   �� *AccountName+$, PropertyChanged=�$0 TwoWay=��� 5�  *   ��62   �� *
BankName+$, PropertyChanged=�$0 TwoWay=��� 5�  *   ��62   �� *AccountNumber+$, PropertyChanged=�$0 TwoWay=��� 5�  *   ��62   �� *
BankBranch+$, PropertyChanged=�$0 TwoWay=�5�  '   �� 5�  &   -   5        $��SpAccountNavigator��5�  1   $��2��5�  1   $��Center=�6A   .+�5�  *   �� -   5        $��btnUp��5�  1     BoderlessButton#��[ 5�  1   .��5�  .     $% ArrowUp=�6>   $��7��6M   5�  +   �� 5�  *   -   5        $��	tbCounter��5�  4   $��1��6F   @ �� TextAlignment$@ Center=�5�  4   �� 5�  *   -   5        $��btnDown��5�  1   #��[ 5�  1   {�.  .��5�  .     $% 	ArrowDown=�6>   $��7��6O   5�  +   5�  '   5�  #   5�     �� 5�     $��Remarks��6&   $��5��65   $+ Center=�6B   $��Bottom=�6Y   $��0,0,0,39.98q�6t   $��3��6�   �� 5�     
���   �$��1q�69   $��7��6M   $��3��6Z   $��40��5�  %   ._�5�  "   (� .��5�  &   �� $+ Center=�6.   $��Center=�6E   $��Center=�6b   $
��bold"�5�  (   $��monotype corsiva)�6:   $	��400��5�  .   $��0q�6:   ��5�  X   �� *Description+5�  :   5�  #   5�     �� 5�     $��8��5�     $��3��6(   $+ Center=�6<   $��0,0.02,0,15.93q�6S   $��2��6k   ��5�  &   �� *
QuoteTerms+$, PropertyChanged=�$R? LQUOTE TERMS : This Quote is valid for a period of 30 days from date of issue��.��5�  |   5�     �� 5�     $��Center=�6)   $��16��6E   $��9��6Q   $��3��6^   $��20,0.07,20,-0.07q�6r   .+�5�  "   �� $��2��6,   
����� �67   �� 5�  "   $��5��6,   
����  �67   5�     5�     5�     5�     5�     5�     5�     5�     