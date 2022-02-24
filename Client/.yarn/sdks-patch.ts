import fs from "fs";

const le = `
`;

const replacements: {
    [path: string]: { [line: number]: [string, string] };
} = {
    ".yarn/sdks/prettier/index.js": {
        4: [
            "const {createRequire, createRequireFromPath} = require(`module`);",
            `
const external_module_ = require(\`module\`);
const {createRequire, createRequireFromPath} = external_module_;
`.trim(),
        ],
        19: [
            "// Defer to the real prettier/index.js your application uses",
            `
const originalModuleResolveFilename = external_module_.Module._resolveFilename;
external_module_.Module._resolveFilename = function (request, parent, isMain, options) {
    return originalModuleResolveFilename.call(this, request, parent, isMain);
}

// Defer to the real prettier/index.js your application uses
`.trim(),
        ],
    },
};

for (const path in replacements) {
    const repl = replacements[path];

    const loader = fs.readFileSync(path, { encoding: "utf-8" });
    const lines = loader.split(/\r\n|\r|\n/g);

    for (const l in repl) {
        const [curValue, replValue] = repl[+l];
        if (lines[+l - 1] !== curValue) {
            throw new Error(`Unexpected line when patching '${path}'`);
        }
        lines[+l - 1] = replValue;
    }

    fs.writeFileSync(path, lines.join(le), { encoding: "utf-8" });
}
