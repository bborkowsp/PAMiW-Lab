   M S B A M L   `   `   `  ����V  RP04VehicleDealership.Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:P04VehicleDealership.ClientP04VehicleDealership.Client  5   	   +    %P04VehicleDealership.Client.LoginView   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:P04VehicleDealership.Client     5   	   _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  5   	     � Title$  	LoginView��5	   	   $	��190��6   $	��300��6(    � 	Resources 5
         boolToVisConv  mainButtonStyle �� 
TargetType �� Property �� Value  ButtonBackground  ButtonForeground  ButtonBorder��%'  &	        &	      �� 5   
   6@   �� 5   
   " ��6(   .�5      ��  � ��$
 Bold"�6+   �� 5       � ��# �  6+   �� 5       � ��# �  6+   �� 5       � ��# �  6,   �� 5       � ��$ 1q�60   �� 5       �@�Cursor$
 Hand��6'   5      5      .��5      �   ThemeBackgroundColor#���  6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5       $��* �6   .+�5#   
   �� $��Email:��6   $��0��6!   $��0��6.     LabelForeground#���  6>   �� 5$   
   -   5         ��Name$ EmailTextBox��5$      $��0��6(   $��1��65   $��5q�6E   ��6P   �� *UserLoginDTO.Email+ �� Mode$ TwoWay=�	 �� UpdateSourceTrigger$	 PropertyChanged=��� 5&   
     Password#���  6   $��1��65   $��0��6B   #���  6R   G� 5'   
   -   5        
 G�Name$
 PasswordBox��5'      $��1��6+   $��1��68   $��5q�6H    G� PasswordChar$ *��6S   �� 5)   
   -   5         	 Login#���  5)   (   $��40��6J   #��[ 6V   $��2��6   $��36,18,36,20q�6�   $��2��6�   *  $Microsoft.Xaml.Behaviors.Interaction   Triggers 5*      +  %Microsoft.Xaml.Behaviors.EventTrigger  5+         	EventName$ 
MouseEnter��6!   *  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 5,      2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction     Command 6,   �� *MouseEnterCommand+5-      5/      50      51      