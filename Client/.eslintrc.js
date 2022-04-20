// @ts-check

const { resolve } = require("path");

/** @type {import("@typescript-eslint/utils").TSESLint.Linter.Config} */
const config = {
    root: true,
    parser: "@typescript-eslint/parser",
    parserOptions: {
        sourceType: "module",
        ecmaVersion: 2020,
        ecmaFeatures: { jsx: true },
        // project: resolve(__dirname, "./tsconfig.json"),
        // tsconfigRootDir: __dirname,
    },
    env: { browser: true },
    settings: {
        react: {
            // version: "detect",
        },
        componentWrapperFunctions: [],
    },
    plugins: ["@typescript-eslint", "react", "react-hooks"],
    extends: [
        "eslint:recommended",
        "plugin:@typescript-eslint/recommended",
        "plugin:react/recommended",
        "plugin:react-hooks/recommended",
        "plugin:react/jsx-runtime",
        "prettier",
    ],
    rules: {
        curly: ["error", "all"],
        "no-console": "warn",
        "no-debugger": "warn",
        "@typescript-eslint/no-namespace": "off",
        "@typescript-eslint/no-empty-interface": "off"
    },
};

module.exports = config;
