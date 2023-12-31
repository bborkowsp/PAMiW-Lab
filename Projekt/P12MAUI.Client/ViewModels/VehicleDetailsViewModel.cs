﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.ApplicationModel;
using P12MAUI.Client.ViewModels;
using P06VehicleDealership.Shared.MessageBox;
using P06VehicleDealership.Shared.Services.VehicleDealershipService;
using P06VehicleDealership.Shared.VehicleDealership;
using P06VehicleDealership.Shared.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace P12MAUI.Client.ViewModels
{
    [QueryProperty(nameof(Vehicle), nameof(Vehicle))]
    [QueryProperty(nameof(VehiclesViewModel), nameof(VehiclesViewModel))]
    public partial class VehicleDetailsViewModel : ObservableObject
    {
        private readonly IVehicleDealershipService _vehicleDealershipService;
        private readonly IMessageDialogService _messageDialogService;
        private VehiclesViewModel _vehicleViewModel;
        private readonly ILanguageService _languageService;


        public VehicleDetailsViewModel(IVehicleDealershipService vehicleDealership, IMessageDialogService messageDialogService, ILanguageService languageService)
        {
            _vehicleDealershipService = vehicleDealership;
            _messageDialogService = messageDialogService;
            _languageService = languageService;
            SettingsViewModel.LanguageChanged += OnLanguageChanged;
            RefreshAllProperties();
        }

        public VehiclesViewModel VehiclesViewModel
        {
            get
            {
                return _vehicleViewModel;
            }
            set
            {
                _vehicleViewModel = value;
            }
        }

        [ObservableProperty]
        Vehicle vehicle;

        public async Task DeleteVehicle()
        {
            await _vehicleDealershipService.DeleteVehicleAsync(vehicle.Id);
            await _vehicleViewModel.GetVehicles();
        }

        public async Task CreateVehicle()
        {
            var newVehicle = new Vehicle()
            {
                Model = vehicle.Model,
                Fuel = vehicle.Fuel,

            };

            var result = await _vehicleDealershipService.CreateVehicleAsync(newVehicle);
            if (result.Success)
                await _vehicleViewModel.GetVehicles();
            else
                _messageDialogService.ShowMessage(result.Message);
        }

        public async Task UpdateVehicle()
        {
            var vehicleToUpdate = new Vehicle()
            {
                Id = vehicle.Id,
                Model = vehicle.Model,
                Fuel = vehicle.Fuel,
            };

            await _vehicleDealershipService.UpdateVehicleAsync(vehicleToUpdate);
            await _vehicleViewModel.GetVehicles();
        }

        [RelayCommand]
        public async Task Save()
        {
            if (vehicle.Id == 0)
            {
                CreateVehicle();
                await Shell.Current.GoToAsync("../", true);

            }
            else
            {
                UpdateVehicle();
                await Shell.Current.GoToAsync("../", true);
            }

        }

        [RelayCommand]
        public async Task Delete()
        {
            DeleteVehicle();
            await Shell.Current.GoToAsync("../", true);
        }

        private void OnLanguageChanged(object sender, string newLanguage)
        {
            RefreshAllProperties();
        }
        public void RefreshAllProperties()
        {
            OnPropertyChanged();
            var properties = GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (var property in properties)
            {
                OnPropertyChanged(property.Name);
            }
        }

        public string LabelFuelText => _languageService.GetLanguage(SettingsViewModel.Language.ToLower(), "FuelLabel");
        public string DeleteText => _languageService.GetLanguage(SettingsViewModel.Language.ToLower(), "DeleteButton");
        public string SaveText => _languageService.GetLanguage(SettingsViewModel.Language.ToLower(), "SaveButton");

    }
}