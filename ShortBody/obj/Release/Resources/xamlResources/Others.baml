   M S B A M L   `   `   `  ���� D  @ShortBody, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:ShortBody.ValueConvertersShortBody.ValueConverters  S.clr-namespace:ShortBody.Resources.UserControls ShortBody.Resources.UserControls  R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   btvConverter  bgImage  �� ImageSource j� TileMode �� 
TargetType  elementStyle �� Property �� Value  MaterialDesignTextBox �� BasedOn  editingElementStyle=   7System.Windows.Controls.Primitives.DataGridColumnHeader  defaultHeaderStyle&   System.Windows.Controls.DataGrid  MaterialDesignDataGrid  SubDataGridHeader*  $System.Windows.Controls.DataGridCell  UnderlineContent �� 
TargetType J� SnapsToDevicePixels �� TextDecorations	 �� Triggers
 P� Property P� Value 	 MaterialDesignTextBoxBorder ]� 
Conditions �� Property �� Value 
 MaterialDesignSelection  MaterialDesignBody  QuoteItemsRow)  #System.Windows.Controls.DataGridRow ��Name?  9System.Windows.Controls.Primitives.SelectiveScrollingGrid � ColumnDefinitions � RowDefinitions?  9System.Windows.Controls.Primitives.DataGridCellsPresenter   
ItemsPanelA  ;System.Windows.Controls.Primitives.DataGridDetailsPresenter   DetailsVisibility$   SelectiveScrollingOrientation;  5System.Windows.Controls.SelectiveScrollingOrientation   Vertical �� ConverterParameter#   RowDetailsScrollingConverter �� 	Converter �� RelativeSource �� AncestorType:  4System.Windows.Controls.Primitives.DataGridRowHeader7	  1System.Windows.Controls.DataGridHeadersVisibility
 	  Row!   HeadersVisibilityConverter  MaterialDesignDivider�� D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     6
converters'clr-namespace:ShortBody.ValueConverters  8local.clr-namespace:ShortBody.Resources.UserControls  %  &	        &	      &	 4     &	 Y     7  '   �     &	 ;    '  �    7  7  &	     &	 �    &	 �    �� �� $  /Resources/Images/bg.png��$
 Tile=��� " ��.���  � ��$
 Wrap=��� " ��8   .���  �@��TextWrapping$
 Wrap=���  �@��AcceptsReturn . �� "   .���  � ��$ 15(���  � ��$ SemiBold"���  � ��
 �������  � �� �#3C8DBC��  � ��$ 10q��� "   .���  � ��$ 15(���  � ��$ SemiBold"���  � ��
 �������  � �� �#3C8DBC��  � ��$ 10q��� "  8   .���  �@ ColumnHeaderStyle8  ��  � ��$ Arial)��� "   .���  � ��$ 15(���  � ��$ SemiBold"���  � ��
 �������  � �� �#1BA1E2��  � ��$ 10q��� "  .���  � ��$ 4q���  � ��
 ���� ��  � ��
 ���� ��  � �� �� "  .R��� #��z��#��z��#��z�� . ._��� $��
MidTextBox��# z #��z��$ 	Underline{�	 P� 
 �@J�IsKeyboardFocusWithin . . ���  � ��# � 	 ]�  ��  �@ 
IsSelected . ��  �@��IsSelectionActive .  ./���  � ��# � 
 ]�  ��  �@ 
IsSelected . ��  �@��IsSelectionActive . ./���  � ��# �  P� 
 � {� .  . ���  �@J�Opacity$	 .56Q��� "  .���  � ��
 ���� ��  �@J�SnapsToDevicePixels . ��  �@=�ErrorTemplate Z� ��  �@ ValidationErrorTemplate �� .R��� ���#d50000$��2,0,0,0q�$��!��$��Center=���  � �� �� "  .R��� $ 
DGR_Border��#��z��#��z��#��z�� . ._�   �� $
��Auto ��� $��* � �� $��* ��� $
��Auto �.+�  $��1��#��z # z   $��1��$��1��#y�z  �� *AreRowDetailsFrozen+# Z # Z  �� "    $��2��$ Vertical=�y��� *HeadersVisibility+# Z # Z  �� "  	 P� 
 �@ 
IsSelected . . ���  � ��# � 
 P� 
 �@J�IsMouseOver . . ���  � ��# �  P� 
 �@ 	IsNewItem . . ���  � ��$ 0q�