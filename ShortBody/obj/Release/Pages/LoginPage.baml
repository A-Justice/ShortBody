   M S B A M L   `   `   `  ���� D  @ShortBody, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ShortBody.PagesShortBody.Pages      ShortBody.Pages.LoginPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     /localclr-namespace:ShortBody.Pages     -   $	��270��$	��430��.���    MaterialDesignPaper#��[    � ColumnDefinitions  �� $��* ��� $
��Auto �.+��  � RowDefinitions �� $	��19* ��� $	��76* ��� $	��20* �.+�(� $��1��$��10q�.���� .+���   tb#��[ $��	Companion��
����  �$��monotype corsiva)��� #��[ $��Systems��
����  �$��monotype corsiva)� �� TextAlignment$ Center=�� $��1��$��20q�  �� $
��Auto ��� $
��Auto �.+��� $��10,15,10,10q�.+��� #��[ $��Company Name :��$ Center=�$��Right=�$
��0,10q��� #��[ $��
Username :��$ Center=�$��Right=�$
��0,10q��� #��[ $��
Password :��$ Center=�$��Right=�$
��0,10q��� $��1��$��10q�.+��� $��80��$
��0,10q����� *	Companies+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=� �� SelectedItem �� *SelectedCompany+���� .R��� #��[ ���� *Name+�� $
��0,10q����� *
UserName+$ PropertyChanged=�$ TwoWay=�G� -   $��
PbPassword��$
��0,10q��� $��LogIn��$
��0,10q�$��70������ *LoginCommand+