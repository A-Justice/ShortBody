   M S B A M L   `   `   `  ����D  @ShortBody, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:ShortBody.ValueConvertersShortBody.ValueConverters  5      S.clr-namespace:ShortBody.Resources.UserControls ShortBody.Resources.UserControls  5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   btvConverter  bgImage  �� ImageSource j� TileMode �� 
TargetType  elementStyle �� Property �� Value  MaterialDesignTextBox �� BasedOn  editingElementStyle=   7System.Windows.Controls.Primitives.DataGridColumnHeader  defaultHeaderStyle&   System.Windows.Controls.DataGrid  MaterialDesignDataGrid  SubDataGridHeader*  $System.Windows.Controls.DataGridCell  UnderlineContent �� 
TargetType J� SnapsToDevicePixels �� TextDecorations	 �� Triggers
 P� Property P� Value 	 MaterialDesignTextBoxBorder ]� 
Conditions �� Property �� Value 
 MaterialDesignSelection  MaterialDesignBody  QuoteItemsRow)  #System.Windows.Controls.DataGridRow ��Name?  9System.Windows.Controls.Primitives.SelectiveScrollingGrid � ColumnDefinitions � RowDefinitions?  9System.Windows.Controls.Primitives.DataGridCellsPresenter   
ItemsPanelA  ;System.Windows.Controls.Primitives.DataGridDetailsPresenter   DetailsVisibility$   SelectiveScrollingOrientation;  5System.Windows.Controls.SelectiveScrollingOrientation   Vertical �� ConverterParameter#   RowDetailsScrollingConverter �� 	Converter �� RelativeSource �� AncestorType:  4System.Windows.Controls.Primitives.DataGridRowHeader7	  1System.Windows.Controls.DataGridHeadersVisibility
 	  Row!   HeadersVisibilityConverter  MaterialDesignDivider�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      6
converters'clr-namespace:ShortBody.ValueConverters  5      8local.clr-namespace:ShortBody.Resources.UserControls  5      %[  &	        &	      &	 U     &	 �     7  '   5    &	     '      7  7  &	 �    &	 i    &	 �    �� 5      6#   �� 5      $  /Resources/Images/bg.png��6!   $
 Tile=�6H   �� 5      " ��6   .�5   
   ��  � ��$
 Wrap=�6)   68   5      �� 5      " ��6   8   .�5   
   ��  �@��TextWrapping$
 Wrap=�6)   68   �� 5   
    �@��AcceptsReturn . 69   5      �� 5"      "   6   .�5#   
   ��  � ��$ 15(�6%   �� 5$   
    � ��$ SemiBold"�6'   �� 5%   
    � ��
 �����6'   �� 5&   
    � �� �#3C8DBC6'   �� 5'   
    � ��$ 10q�6$   5(      �� 5*      "   6   .�5+   
   ��  � ��$ 15(�6%   �� 5,   
    � ��$ SemiBold"�6'   �� 5-   
    � ��
 �����6'   �� 5.   
    � �� �#3C8DBC6'   �� 5/   
    � ��$ 10q�6$   50      �� 53      "  6   8   .�54   
   ��  �@ ColumnHeaderStyle8  6.   �� 55   
    � ��$ Arial)�6'   57      �� 59      "   6   .�5:   
   ��  � ��$ 15(�6%   �� 5;   
    � ��$ SemiBold"�6'   �� 5<   
    � ��
 �����6'   �� 5=   
    � �� �#1BA1E26'   �� 5>   
    � ��$ 10q�6$   5?      �� 5C      "  6   .�5F   
   ��  � ��$ 4q�6$   �� 5G   
    � ��
 ���� 6'   �� 5H   
    � ��
 ���� 6(   �� 5I   
    � �� 5J      �� 5K      "  6"   .R�5L      �� #��z��6   #��z��6I   #��z��6}    . ._�5M      �� $��
MidTextBox��6"   # z 64   #��z��5N   +   $ 	Underline{�6N   5O      5P      5S      	 5V   
   P� 5W      
 �@J�IsKeyboardFocusWithin . . �5X      ��  � ��# � 	 60   5Y      ]� 5Z       5[      �� 5\       �@ 
IsSelected . 66   �� 5]       �@��IsSelectionActive .  6F   ./�5_      ��  � ��# � 
 6/   5`      ]� 5a       5b      �� 5c       �@ 
IsSelected . 66   �� 5d       �@��IsSelectionActive . 6F   ./�5f      ��  � ��# �  6/   5g      P� 5h      
 � {� .  . �5i      ��  �@J�Opacity$	 .56Q�6,   5j      5l      �� 5o      "  6"   .�5q   
   ��  � ��
 ���� 6'   �� 5r   
    �@J�SnapsToDevicePixels . 60   �� 5s   
    �@=�ErrorTemplate 65   Z� �� 5t   
    �@ ValidationErrorTemplate 5u      �� 5v      .R�5w      �� ���#d50000$��2,0,0,0q�65   $��!��6F   $��Center=�6O   5x      5z      �� 5{   
    � �� 5|      �� 5}      "  6"   .R�5~      �� $ 
DGR_Border��6   #��z��61   #��z��6]   #��z��6�    . ._�5         5�      �� 5�   "   $
��Auto �63   �� 5�   "   $��* �63    5�      �� 5�   "   $��* �60   �� 5�   "   $
��Auto �60   .+�5�        $��1��65   #��z 6E   # z 6o     5�      $��1��67   $��1��6G   #y�z 5�   7    5�   7   �� *AreRowDetailsFrozen+# Z # Z  �� "  5�   7     5�      $��2��60   $ Vertical=�5�   0   y�6p   �� *HeadersVisibility+# Z # Z  �� "  5�      5�      5�      5�      	 5�   
   P� 5�      
 �@ 
IsSelected . . �5�      ��  � ��# � 
 6/   5�      P� 5�      
 �@J�IsMouseOver . . �5�      ��  � ��# �  6/   5�      P� 5�      
 �@ 	IsNewItem . . �5�      ��  � ��$ 0q�6+   5�      5�      5�      