   M S B A M L   `   `   `  ����D  @ShortBody, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ShortBody.PagesShortBody.Pages  5          ShortBody.Pages.LoginPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:ShortBody.Pages     5      -   5        $	��270��5      $	��430��6   .��5
      �    MaterialDesignPaper#��[  6     � ColumnDefinitions  5   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �  � RowDefinitions 5      �� 5      $	��19* �6    �� 5      $	��76* �6    �� 5      $	��20* �6    .+�5      (� $��1��6   $��10q�6#   .��5      �� .+�5      ��   tb#��[ 6    $��	Companion��6<   
����  �$��monotype corsiva)�6_   �� 5      #��[ 6    $��Systems��6<   
����  �$��monotype corsiva)�6]    �� TextAlignment$ Center=�5       5      5      5      � 5   
   $��1��6   $��20q�6     5      �� 5       $
��Auto �6#   �� 5!      $
��Auto �6#   .+�5#      �� $��10,15,10,10q�6   .+�5$      �� #��[ 6   $��Company Name :��68   $ Center=�6N   $��Right=�5%      $
��0,10q�68   �� 5&      #��[ 6   $��
Username :��68   $ Center=�6J   $��Right=�5'      $
��0,10q�68   �� 5)      #��[ 6   $��
Password :��68   $ Center=�6J   $��Right=�5*      $
��0,10q�68   5+      �� 5-      $��1��6   $��10q�5.      .+�5/      �� $��80��6   $
��0,10q�6&   ��64   �� *	Companies+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=� �� SelectedItem 50      �� *SelectedCompany+��51      �� 52      .R�53      �� #��[ 6(   ��6D   �� *Name+54      56      �� 57      $
��0,10q�6   ��6(   �� *
UserName+$ PropertyChanged=�$ TwoWay=�G� 58      -   5        $��
PbPassword��58      $
��0,10q�60   6>   �� 59      $��LogIn��6   $
��0,10q�5:      $��70��6'   ��59   )   �� *LoginCommand+5:   '   5;      5<      5=      5>      