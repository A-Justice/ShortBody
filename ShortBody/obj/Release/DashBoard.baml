   M S B A M L   `   `   `  ���� Z  VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466J6clr-namespace:FontAwesome.WPF;assembly=FontAwesome.WPFFontAwesome.WPF  D @ShortBody, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:ShortBody.ValueConvertersShortBody.ValueConverters %clr-namespace:ShortBody	ShortBody S.clr-namespace:ShortBody.Resources.UserControls ShortBody.Resources.UserControls    ShortBody.DashBoard   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     Efa6clr-namespace:FontAwesome.WPF;assembly=FontAwesome.WPF     6cv'clr-namespace:ShortBody.ValueConverters     )localclr-namespace:ShortBody     >ctr.clr-namespace:ShortBody.Resources.UserControls     -   
�������.���    myLightDark#��[    � RowDefinitions  �� $
��Auto ��� $
��259* � � ColumnDefinitions �� $
��Auto ��� $��* �.+�� $��2��  DeepBlue#��[  �� $
��auto ��� $
��auto ��� $��* ��� $
��Auto ��� $
��Auto ��� $
��auto �.+�A� $��40��$��40��$��5q�����  j� Stretch$ UniformToFill=� �� ImageSource �� *Logo+ �� IsAsync .  �� 	Converter 4  .ShortBody.ValueConverters.ByteToImageConverter   �� UpdateSourceTrigger$ PropertyChanged=��� $��1��$��20(�$��	10,0,10,0q� �� TextAlignment$
 Left=�$��Center=����� *CompanyName+�� -   $��	TopHeader��$��Center=�$��Algerian)�$��Center=�$��15(�$��2��$��CLIENTS��A� $��4��$��Center=�$��5q�$��40��$��40�� � DataContext �� *CurrentUser+���� $ UniformToFill=� �� *	UserImage+ . $ PropertyChanged=�   �� $��5q�$��3��	 �� Orientation$	 
Horizontal=�.+��� $��Welcome��$��Center=�$��10,0,3,0q��� $��Center=�$��3,0,5,0q�$ Center=� �� *CurrentUser+���� *	FirstName+�� -   $��5��$	 
Horizontal=�.+�7  1ShortBody.Resources.UserControls.NotificationIcon  -   
  Name$
 QuotationNotification��7  1ShortBody.Resources.UserControls.NotificationIcon   Click$! QuotationNotification_Click��$��Center=� � Cursor$
 Hand��$��Center=�$��40��$��40��
�������   Count �� *UnpaidQuotationCount+ .  (ShortBody.ValueConverters.dummyConverter  .��"   FontAwesome.WPF.ImageAwesome     Icon$ DriversLicense=�   
Foreground
 ������� $��Logout��$��10q�$
 Hand��
����������� *LogoutCommand+�� -   $��btnToggleSideNav��$��50��$��50��$
��Left=�$��0q�$	��1,5q�$��1��$	��Top=�.��  $ Navicon=�$��30��
 ������� -    ��Name$ SideNav��$��1��
������ $��5,50,0,0q�$��45��
�������
������ $
��Left=�.@��� -   $��	spSideNav��|�.  .+�2  ,ShortBody.Resources.UserControls.LinedButton  -     Name$ btnShowClients��2  ,ShortBody.Resources.UserControls.LinedButton   Click$ LinedButton_Click��$	��1,5q�$��50��   ShowLine . ���� *OpenClients+.���� $	 
Horizontal=�.+�  $ Users=�
 �����$��30���� $��CLIENTS��$
��Bold"�$	��100��$��18(� �� Padding$ 5q�
�������$��Center=�  $ LinedButton_Click��$	��1,5q�$��50������ *OpenInvoice+.���� $	 
Horizontal=�.+�  $ NewspaperOutline=�$��30��
 ������� $��INVOICES��$
��Bold"�$	��100��$��18(�$ 5q�
�������$��Center=�  -	   $ btnQuotation��$ LinedButton_Click��$	��1,5q�$��50������ *OpenQuotation+.���� $	 
Horizontal=�.+�  $ DriversLicense=�$��30��
 ������� $��	QUOTATION��$
��Bold"�$	��115��$��18(�$ 5q�
�������$��Center=�  $ LinedButton_Click��$	��1,5q�$��50������ *OpenSuppliers+.���� $	 
Horizontal=�.+�  $ Truck=�$��30��
 ������� $��	SUPPLIERS��$��Center=�$
��Bold"�$	��110��
�������$��18(�$ 5q�  $ LinedButton_Click��$	��1,5q�$��50������ *OpenEspenses+.���� $	 
Horizontal=�.+��� $	 
Horizontal=�.+�  $ Money=�$��15��$��50��
 �����  $
 Etsy=�$��15��
 ������� $��EXPENSES��$��Center=�$
��Bold"�$	��110��
�������$��18(�$ 5q�  $ LinedButton_Click��$��50��$	��1,5q����� *
OpenIncome+.���� $	 
Horizontal=�.+��� $	 
Horizontal=�.+�  $ Money=�$��15��
 �����  $ Italic=�$��15��
 ����� J� RenderTransformOrigin$ 0.5,0.5&�z�V� .~��� �� ��  �� Angle$	 -11Q�T� �� $��INCOME��$��Center=�$
��Bold"�$	��100��$��18(�$ 5q�
�������  -
   $ btnShowPaymentAdvice��$ LinedButton_Click��$	��1,5q�$��50������ *OpenPaymentAdvice+.���� $	 
Horizontal=�.+�  $ FileOutline=�
 �����$��30���� $��P-ADVICE��$
��Bold"�$	��100��$��18(�$ 5q�
�������$��Center=�  -   $ btnCompanies��$ LinedButton_Click��$	��1,5q�$��50������ *OpenCompanies+.���� $	 
Horizontal=�.+�  $ Industry=�$��30��
 ������� $��	Companies��$��Center=�$
��Bold"�$	��110��
�������$��18(�$ 5q�  -   $ btnUsers��$ LinedButton_Click��$	��1,5q�$��50������ *	OpenUsers+.���� $	 
Horizontal=�.+�  $
 User=�$��30��
 ������� $��Users��$��Center=�$
��Bold"�$	��110��
�������$��18(�$ 5q� � $��1��$��1��  
ShinyWhite#��[   � NavigationUIVisibility$ Hidden=����� *DashBoardPage+$ PropertyChanged=� 6  0ShortBody.ValueConverters.DashBoardPageConverter  