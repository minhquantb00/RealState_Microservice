﻿using RealEstate.Shared.Models.Entities.Contracts;

namespace ContractsMicroservice.Services.Interfaces
{
    /// <summary>
    /// Represents a service for managing checklists.
    /// </summary>
    public interface IChecklistService
    {
        /// <summary>
        /// Gets a list of checklists for a user.
        /// </summary>
        /// <param name="userId">The ID of the user whose checklists to retrieve.</param>
        /// <returns>A list of <see cref="Checklist"/> objects representing the checklists for the user.</returns>
        IEnumerable<Checklist> GetChecklistsList(int userId);

        /// <summary>
        /// Deletes a checklist.
        /// </summary>
        /// <param name="userId">The ID of the user who owns the checklist.</param>
        /// <param name="checklistId">The ID of the checklist to delete.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        Task DeleteChecklist(int userId, int checklistId);

        /// <summary>
        /// Checks if a user has a specific checklist.
        /// </summary>
        /// <param name="userId">The ID of the user.</param>
        /// <param name="checklistId">The ID of the checklist.</param>
        /// <returns>A task representing the asynchronous operation, with a result indicating whether the user has the checklist.</returns>
        Task<bool> CheckIfUserHasChecklist(int userId, int checklistId);

        /// <summary>
        /// Validates a checklist model.
        /// </summary>
        /// <param name="model">The checklist model to validate.</param>
        void ValidateModel(Checklist model);
    }
}
