   M S B A M L   `   `   `  ����V  RP04VehicleDealership.Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:P04VehicleDealership.ClientP04VehicleDealership.Client  5   	   ,    &P04VehicleDealership.Client.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:P04VehicleDealership.Client     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��640��6)    � 	Resources 5	         boolToVisConv  mainButtonStyle �� 
TargetType �� Property �� Value  ButtonBackground  ButtonForeground  ButtonBorder  mainLabelStyle��%  &	        &	      &	 Z    �� 5
   
   6@   �� 5   
   " ��6(   .�5      ��  � ��$ 5q�6'   �� 5       � ��$ 10q�6(   �� 5       � ��$
 Bold"�6+   �� 5       � ��# �  6+   �� 5       � ��# �  6+   �� 5       � ��# �  6,   �� 5       � ��$ 1q�60   �� 5       �@�Cursor$
 Hand��6'   5      �� 5   
   " ��6'   .�5      ��  � ��$ 18(�6)   �� 5       � ��$ Center=�64   �� 5       � ��
 �   �6+   5      5      .��5      �   ThemeBackgroundColor#���  6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5       $��* �6    � ColumnDefinitions 5"   
   �� 5#      $��* �6   .+�5%      ]� $��0��6   $��0��6    $��10q�6-   .+�5&   
   �� $	��Top=�6    	 Login#���  6&   #��[ 6s   $��0,90,0,5q�6�   $	��242��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   ��6H   �� *OpenLoginWindowCommand+z�5'      V� 5(      .~�5)      �� �� 5*       �� AngleY$ -0.158Q�6(   �� 5+      T� 5,      	 T� Y$	 -0.331Q�6-   5-      5/      �� 50      $	��Top=�6     OpenVehicleDealership#���  6*   #��[ 6�   $��0,0,0,5q�6�   $	��243��6�   ��6\   �� *$"OpenVehicleDealershipWindowCommand+6�   �� 51   
   
 �� Orientation$
 
Horizontal=�6   $��Center=�6.   .+�52      �� $	��Top=�6    	 ChangeTheme#��� 	 6*   #��[ 6y   $��0,0,5,0q�6�   $��Center=�6�   $	��120��6�   ��6R   �� *ChangeThemeCommand+6�   �� 53      $	��Top=�6    
 ChangeLanguage#��� 
 6*   #��[ 6   $��0,0,0,0q�6�   $��Center=�6�   $	��120��6�   ��6U   �� *ChangeLanguageCommand+6�   54      55      57      5:      