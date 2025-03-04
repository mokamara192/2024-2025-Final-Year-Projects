// src/utils/currencyConverter.js

// Fixed conversion rate: 26 NLE = 1 USD
const conversionRate = 26;

/**
 * Converts an amount in Sierra Leonean Leones (NLE) to USD.
 * @param {number} amountInNLE - The amount in NLE.
 * @returns {number} - The equivalent amount in USD.
 */
export function convertNLEtoUSD(amountInNLE) {
    if (typeof amountInNLE !== "number") {
        throw new Error("Amount must be a number.");
    }
    return +(amountInNLE / conversionRate).toFixed(2); // rounding to 2 decimals for USD
}
