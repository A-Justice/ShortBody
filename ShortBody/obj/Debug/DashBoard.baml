   M S B A M L   `   `   `  ����Z  VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466J6clr-namespace:FontAwesome.WPF;assembly=FontAwesome.WPFFontAwesome.WPF  5      D @ShortBody, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:ShortBody.ValueConvertersShortBody.ValueConverters 5      %clr-namespace:ShortBody	ShortBody 5      S.clr-namespace:ShortBody.Resources.UserControls ShortBody.Resources.UserControls 5	         ShortBody.DashBoard   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Efa6clr-namespace:FontAwesome.WPF;assembly=FontAwesome.WPF     5      6cv'clr-namespace:ShortBody.ValueConverters     5      )localclr-namespace:ShortBody     5      >ctr.clr-namespace:ShortBody.Resources.UserControls     5	      -   5        
�������.��5      �    myLightDark#��[  6     � RowDefinitions  5   
   �� 5      $
��Auto �6   �� 5      $
��259* �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   � $��2��6     DeepBlue#��[ 6#    5      �� 5      $
��auto �6#   �� 5      $
��auto �6#   �� 5      $��* �6#   �� 5      $
��Auto �6#   �� 5      $
��Auto �6#   �� 5       $
��auto �6#   .+�5#      A� $��40��6   $��40��6!   $��5q�6-   ��5$      �� 5%       j� Stretch$ UniformToFill=�6!    �� ImageSource 69   �� *Logo+ �� IsAsync .  �� 	Converter 4  .ShortBody.ValueConverters.ByteToImageConverter   �� UpdateSourceTrigger$ PropertyChanged=�5(      �� 5+      $��1��65   $��20(�5,      $��	10,0,10,0q�6&    �� TextAlignment$
 Left=�5-      $��Center=�6-   ��5+      �� *CompanyName+5-   -   �� 5/      -   5        $��	TopHeader��5/      $��Center=�6)   $��Algerian)�6F   $��Center=�50      $��15(�63   $��2��6B   $��CLIENTS��6R   6c   A� 52      $��4��6   $��Center=�53      $��5q�60   $��40��6;   $��40��6G    � DataContext 52   '   �� *CurrentUser+��54      �� 55      $ UniformToFill=�56       55   !   �� *	UserImage+ . $ PropertyChanged=�   56      59      �� 5;      $��5q�6   $��3��6%   	 �� Orientation$	 
Horizontal=�65   .+�5<      �� $��Welcome��6   $��Center=�6+   $��10,0,3,0q�6F   �� 5=      $��Center=�5>      $��3,0,5,0q�64   $ Center=�5?       5=      �� *CurrentUser+��6A   �� *	FirstName+5?      5@      �� 5B      -   5        $��5��5B      $	 
Horizontal=�6*   .+�5H      7  1ShortBody.Resources.UserControls.NotificationIcon  -   5        
  Name$
 QuotationNotification��5K   '   7  1ShortBody.Resources.UserControls.NotificationIcon   Click$! QuotationNotification_Click��5J   &   $��Center=�5H   '    � Cursor$
 Hand��6D   $��Center=�5I   '   $��40��5L   '   $��40��63   
�������   Count 5I   B   �� *UnpaidQuotationCount+ .  (ShortBody.ValueConverters.dummyConverter  .��5M      "   FontAwesome.WPF.ImageAwesome     Icon$ DriversLicense=�6&      
Foreground
 �����6=   5O      �� 5P      $��Logout��6   $��10q�6*   $
 Hand��66   
���������5Q      �� *LogoutCommand+67   5S      5T   
   �� 5V   
   -   5        $��btnToggleSideNav��5V      $��50��6)   $��50��65   $
��Left=�5W      $��0q�60   $	��1,5q�6D   $��1��5X      $	��Top=�6"   .��5Y        $ Navicon=�6   $��30��6-   
 �����68   5[      �� 5^   
   -   5         ��Name$ SideNav��5^   =   $��1��6   
������ $��5,50,0,0q�5_      $��45��6$   
�������
������ $
��Left=�5`   ?   .@�5b      �� -   5        $��	spSideNav��5b   ,   |�.  .+�5d      2  ,ShortBody.Resources.UserControls.LinedButton  -   5          Name$ btnShowClients��5e   A   2  ,ShortBody.Resources.UserControls.LinedButton   Click$ LinedButton_Click��6'   $	��1,5q�5d   A   $��50��6N      ShowLine . ��6!   �� *OpenClients+.��5f      �� $	 
Horizontal=�6!   .+�5h        $ Users=�6*   
 �����$��30��5j   *   �� 5k      $��CLIENTS��6$   $
��Bold"�64   $	��100��6F   $��18(�5l        �� Padding$ 5q�6.   
�������$��Center=�5m       5n      5o        5s      $ LinedButton_Click��5t   !   $	��1,5q�5s   B   $��50��5t   ;   ��5s   "   �� *OpenInvoice+.��5u      �� $	 
Horizontal=�6!   .+�5v        $ NewspaperOutline=�6*   $��30��5w   *   
 �����66   �� 5x      $��INVOICES��6$   $
��Bold"�64   $	��100��6F   $��18(�5y       $ 5q�6.   
�������$��Center=�5z       5{      5|        5      -	   5        $ btnQuotation��5�   "   $ LinedButton_Click��5�   "   $	��1,5q�5   D   $��50��5�   <   ��5   "   �� *OpenQuotation+.��5�      �� $	 
Horizontal=�6!   .+�5�        $ DriversLicense=�6*   $��30��5�   *   
 �����66   �� 5�      $��	QUOTATION��6$   $
��Bold"�66   $	��115��6H   $��18(�5�       $ 5q�6.   
�������$��Center=�5�       5�      5�        5�      $ LinedButton_Click��5�   "   $	��1,5q�5�   D   $��50��5�   <   ��5�   "   �� *OpenSuppliers+.��5�      �� $	 
Horizontal=�6!   .+�5�        $ Truck=�6*   $��30��67   
 �����5�   +   �� 5�      $��	SUPPLIERS��6$   $��Center=�65   $
��Bold"�5�   (   $	��110��6:   
�������$��18(�5�       $ 5q�6.   5�      5�        5�      $ LinedButton_Click��6\   $	��1,5q�6C   $��50��6P   ��6"   �� *OpenEspenses+.��5�      �� $	 
Horizontal=�6!   .+�5�      �� $	 
Horizontal=�6%   .+�5�        $ Money=�6.   $��15��6;   $��50��6F   
 �����5�   /     5�      $
 Etsy=�6.   $��15��6:   
 �����5�   /   5�      �� 5�      $��EXPENSES��6$   $��Center=�64   $
��Bold"�5�       $	��110��62   
�������$��18(�5�       $ 5q�6.   5�      5�        5�      $ LinedButton_Click��6Z   $��50��6A   $	��1,5q�6M   ��6"   �� *
OpenIncome+.��5�      �� $	 
Horizontal=�6!   .+�5�      �� $	 
Horizontal=�6%   .+�5�        $ Money=�6.   $��15��6;   
 �����5�   0     5�      $ Italic=�6.   $��15��6<   
 ����� J� RenderTransformOrigin$ 0.5,0.5&�5�   C   z�5�   "   V� 5�   &   .~�5�   *   �� �� 5�   *   �� 5�   *    �� Angle$	 -11Q�6:   T� 5�   *   5�   '   5�      5�      �� 5�      $��INCOME��6$   $��Center=�62   $
��Bold"�6M   $	��100��6_   $��18(�5�       $ 5q�6.   
�������6:   5�      5�        5�      -
   5        $ btnShowPaymentAdvice��5�   2   $ LinedButton_Click��6   $	��1,5q�5�   H   $��50��6U   ��6"   �� *OpenPaymentAdvice+.��5�      �� $	 
Horizontal=�6!   .+�5�        $ FileOutline=�6*   
 �����$��30��5�   *   �� 5�      $��P-ADVICE��6$   $
��Bold"�65   $	��100��6G   $��18(�5�       $ 5q�6.   
�������$��Center=�5�       5�      5�        5�      -   5        $ btnCompanies��5�   D   $ LinedButton_Click��5�   /   $	��1,5q�6"   $��50��6I   ��5�   "   �� *OpenCompanies+.��5�      �� $	 
Horizontal=�6!   .+�5�        $ Industry=�6*   $��30��6:   
 �����5�   +   �� 5�      $��	Companies��6$   $��Center=�65   $
��Bold"�5�   (   $	��110��6:   
�������$��18(�5�       $ 5q�6.   5�      5�        5�      -   5        $ btnUsers��5�   4   $ LinedButton_Click��6   $	��1,5q�5�   @   $��50��5�   F   ��5�   "   �� *	OpenUsers+.��5�      �� $	 
Horizontal=�6!   .+�5�        $
 User=�6*   $��30��66   
 �����5�   +   �� 5�      $��Users��6$   $��Center=�61   $
��Bold"�5�   (   $	��110��6:   
�������$��18(�5�       $ 5q�6.   5�      5�      5�      5�       � 5�   
   $��1��6   $��1��6     
ShinyWhite#��[ 6-     � NavigationUIVisibility$ Hidden=�6V   ��5�      �� *DashBoardPage+$ PropertyChanged=� 6  0ShortBody.ValueConverters.DashBoardPageConverter  5�      5�      5�      