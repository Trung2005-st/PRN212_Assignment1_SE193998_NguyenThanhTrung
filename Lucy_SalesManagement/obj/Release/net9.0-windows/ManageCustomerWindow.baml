   M S B A M L   `   `   `  ����   Lucy_SalesManagement/    )Lucy_SalesManagement.ManageCustomerWindow   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  Manage Customers�� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ 	CanResize=�$	��900��$	��600�����#F5F7FA � 	Resources 3  -System.Windows.Media.Effects.DropShadowEffect   ButtonNormalShadow   Color   
BlurRadius   ShadowDepth   Opacity  ButtonHoverShadow  	NavButton �� 
TargetType	 �� Property
 �� Value �� 
TargetType �� CornerRadius �� Triggers P� Property P� Value  
InputStyle ��Name  PrimaryButton �� BasedOn ��Name J� Effect �� 
TargetName��%�  &	        &	 /     &	 _     &	 �    &	 �    7  7   7  7     $ 	#44000000��$ 8Q�$ 2Q�$	 0.5Q�  $ 	#66000000��$ 16Q�$ 4Q�$	 0.8Q��� " ��.��� 	 � ��

 ���� �� 	 � ��

 ������� 	 � ��$	
 8,4q��� 	 � ��$
 SemiBold"��� 	 �@�Cursor$

 Hand���� 	 � ��$
 0q��� 	 � ��
 �� " ��.R��� #��z��$ 4��._��� $��Center=�$��Center=� P�  �@J�IsMouseOver$
 True��. ��� 	 � ��
 �	#44FFFFFF�� " ��.��� 	 � ��$
 0,2,0,2q��� 	 � ��$
 24���� 	 � ��$
 14(��� 	 � ��$
 4q��� 	 � ��
 �#CCC�� 	 � ��

 ������� 	 � ��$
 1q��� 	 � ��
 �� " ��.R��� #��z��#��z��#��z��$ 4��._��� $ PART_ContentHost��$��0q��� " ��8   .��� 	 � ��
 �#2C3E50�� 	 � ��

 ������� 	 � ��$
 14(��� 	 � ��$	
 8,4q��� 	 � ��$
 32���� 	 � ��$
 4q��� 	 �@J�Effect8
  �� 	 � ��
 �� " ��.R��� $ border��#��z��$ 4��# z ._��� $��Center=�$��Center=� P�  �@J�IsMouseOver$
 True��. ��� $ border��8
  	 �@J�EffectP�  � ��$
 True��. ��� $ border��8
  	 �@J�Effect.��]� .+�� $	��Top=�$��60�����#2C3E50 � ColumnDefinitions �� $��* ��� $
��Auto �.+��� $��LucySale��$��Center=�$��24,0,0,0q�$��24(�$
��Bold"�
��������� -   $��1��$��Logout��#��[ $��0,0,24,0q�$��Center=��� $	��Top=�
������� �� Padding$ 16,12q����#EEE$��0,0,0,1q�._��� $��Manage Customers��$��16(����#333� $��24q� � RowDefinitions �� $
��132* ��� $	��83* � �� $��2* ��� $��1* �.+�&   System.Windows.Controls.DataGrid  -     Name$ dgCustomers��   AutoGenerateColumns$ False��   CanUserAddRows$ False��   SelectionMode$ Single=�   HeadersVisibility$ Column=�$��0��$
��Left=�$	��587��$��2��$��	-19,0,0,0q�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ 
CustomerID��   Width5  /System.Windows.Controls.DataGridLengthConverter$ 80 1  +System.Windows.Controls.DataGridBoundColumn    Binding  �� *
CustomerID+  $ CompanyName��$ *   �� *CompanyName+  $ ContactName��$	 120   �� *ContactName+  $ ContactTitle��$	 100   �� *ContactTitle+  $ Address��$ *   �� *	Address+  $ Phone��$	 100   �� *Phone+� $��1��$��2��$��
10,0,-13,0q� �� $
��Auto ��� $��* � �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto �.+��� $��0��$��0��$��
CustomerID��$��12(�$��Center=�$��0,2,8,2q��� -   ! ��Name$! txtCustomerID��$��0��$��1��#��[ �� $��1��$��0��$��CompanyName��$��12(�$��Center=�$��0,2,8,2q��� -   $! txtCompanyName��$��1��$��1��#��[ �� $��2��$��0��$��ContactName��$��12(�$��Center=�$��0,2,8,2q��� -   $! txtContactName��$��2��$��1��#��[ �� $��3��$��0��$��ContactTitle��$��12(�$��Center=�$��0,2,8,2q��� -   $! txtContactTitle��$��3��$��1��#��[ �� $��4��$��0��$��Address��$��12(�$��Center=�$��0,2,8,2q��� -   $! 
txtAddress��$��4��$��1��#��[ �� $��5��$��0��$��Phone��$��12(�$��Center=�$��0,2,8,2q��� -   $! txtPhone��$��5��$��1��#��[ �� $��6��$��0��$��2��" �� Orientation$" 
Horizontal=�$
��Left=�$��
90,21,0,-9q�.+��� -	   $	��Add��#��[ $��57���� -
   $��Update��#��[ $��57���� -   $��Delete��#��[ $��61��# J� RenderTransformOrigin$# 0.727,0.518&�