   M S B A M L   `   `   `  ����F  BWPFSigninup, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:WPFSigninup.Views.AuthWPFSigninup.Views.Auth  5   	   *    $WPFSigninup.Views.Auth.WindowSign_in   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:WPFSigninup.Views.Auth     5   	     � Title$  WPF - Sign In��5   	   $	��380��6   $	��380��6,   $	��680��6<   $	��680��6H   $	��680��6W   $	��440��6f   $��18(�6v   $��Arial)�6�    � 
ResizeMode$ CanMinimize=�6�   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $	��200 �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6   .+�5"   
   �� $��1��6   $��1��6$   $��0, 20q�61   $
��Bold"�6@   $��44(�6R   $��2��6`    �� TextAlignment$ Center=�6t   	Sign In6�   �� 5#   
   $��1��6   $��2��6$   $��0, 10, 10, 10q�61   $��22(�6H   	Username:6a   �� 5$   
   -   5         ��Name$ 
txtUserame��5$      $��2��6&   $��2��66   $	��300��6C   $��5q�6O   $��Center=�6[   �� 5%   
   -   5         ��Name$ usernameErrorMessage��5%      $��14(�62   
����p��$��2��6[   $��3��6k   6z   �� 5'   
   $��1��6   $��4��6$   $��0, 10, 10, 10q�61   $��22(�6H   	Password:6a   �� 5(   
   -   5        $ txtPassword��5(      $��2��6'   $��4��67   $	��300��6D   $��5q�6P   $��Center=�6\   �� 5)   
   -   5        $ passwordErrorMessage��5)      $��14(�62   
����p��$��2��6[   $��5��6k   6z   �� 5+   
   -   5         ��Name$ SigninButton��5+      $��Sign in��6'   $��1��69   $��6��6I   $��2��6V   $��8q�6j   $��10q�6v    � Cursor$
 Hand��6�   $��44��6�   6�   �� 5,   
   -   5        $ SwitchButton��5,      $��Switch��6'   $��1��68   $��7��6H   $��2��6U   $��14(�6i   $��8q�6w   $��30, 0q�6�   $
 Hand��6�   $��44��6�   6�   �� 52   
   $��3��6   $��1��6    $��9��6-   $
��Fill=�6>   $��/sign-in.jpg��6M   $��10, 0, 0, 0q�6c   53      54      55      