   M S B A M L   `   `   `  ����   Lucy_SalesManagement%    Lucy_SalesManagement.MainWindow   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  Lucy Sales Management�� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=�$	��800��$	��500��
������  � 	Resources    WindowBackground �� 
StartPoint �� EndPoint � Color � Offset  	CardStyle �� 
TargetType	 �� Property
 �� Value3  -System.Windows.Media.Effects.DropShadowEffect   Color   
BlurRadius   ShadowDepth  
InputStyle �� BasedOn �� 
TargetType �� CornerRadius ��Name  PrimaryButton �� Triggers P� Property P� Value��%�  &	        &	 V     &	 �     '�� N    7  'G� #    7  &	 �    �� $	 0,0&�$	 1,1&�.��� $ 	#FF536976��$ 0Q�� $ 	#FF292E49��$ 1Q��� " ��.��� 	 �@��CornerRadius$
 12���� 	 � ��

 ������� 	 �@��Padding$
 24q��� 	 �@J�Effect
   $ 	#44000000��$ 15Q�$ 4Q��� " ��.��� 	 � ��$
 0,8,0,8q��� 	 � ��$
 30���� 	 � ��$
 14(��� " ��8   .��� 	 � ��$
 6q��� 	 � ��
 �#CCC�� 	 � ��
 �#FFF�� 	 � ��$
 1q��� 	 � ��
 �� " ��.R��� #��z��#��z��#��z��$ 4��._��� $ PART_ContentHost��$��0q��� " G�8   .��� 	 � ��$
 6q��� 	 � ��
 �#CCC�� 	 � ��
 �#FFF�� 	 � ��$
 1q��� 	 � ��
 �� " G�.R��� #��z��#��z��#��z��$ 4��._��� $ PART_ContentHost��$��0q��� " ��.��� 	 � ��
 �	#FF536976�� 	 � ��

 ������� 	 � ��$
 14(��� 	 � ��$
 SemiBold"��� 	 � ��$
 32���� 	 � ��$
 0,12,0,0q��� 	 �@�Cursor$

 Hand���� 	 � ��$
 0q��� 	 � ��
 �� " ��.R��� #��z��$ 4��._��� $��Center=�$��Center=� P�  �@J�IsMouseOver$
 True��. ��� 	 � ��
 �	#FF455A64P�  � ��$
 True��. ��� 	 � ��
 �	#FF37474F.��� #��[  .+��� #��[ $	��360��$	��360��$��Center=�$��Center=�._��� .+��� $��Lucy Sales Management��$��20(�$
��Bold"����#333$��Center=��� $��Please log in to continue��$��12(����#666$��0,6,0,16q�$��Center=��� .@��� $��Admin��.���� $��0,8,0,0q�.+��� $��Username��$��12(��� -    ��Name$ txtAdminUser��#��[ �� $��Password��$��12(�G� -    G�Name$ txtAdminPass��#��[ �� -   $��Admin��#��[ �� $��Customer��.���� $��0,8,0,0q�.+��� $��Phone Number��$��12(��� -   $ txtCustomerPhone��#��[ �� -   $��Customer��#��[ 