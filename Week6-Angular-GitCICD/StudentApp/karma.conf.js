// Karma configuration file
if (!process.env.CHROME_BIN) {
  try {
    process.env.CHROME_BIN = require('puppeteer').executablePath();
  } catch {
    // puppeteer not installed (e.g. CI) — CHROME_BIN is expected to be set by the environment instead.
  }
}

module.exports = function (config) {
  config.set({
    basePath: '',
    frameworks: ['jasmine'],
    plugins: [
      require('karma-jasmine'),
      require('karma-chrome-launcher'),
      require('karma-jasmine-html-reporter'),
      require('karma-coverage')
    ],
    client: {
      jasmine: {}
    },
    jasmineHtmlReporter: {
      suppressAll: true
    },
    coverageReporter: {
      dir: require('path').join(__dirname, './coverage/student-course-portal'),
      subdir: '.',
      reporters: [{ type: 'html' }, { type: 'text-summary' }]
    },
    reporters: ['progress'],
    customLaunchers: {
      ChromeHeadlessNoSandbox: {
        base: 'ChromeHeadless',
        flags: ['--no-sandbox', '--disable-gpu', '--disable-dev-shm-usage']
      }
    },
    browsers: ['ChromeHeadlessNoSandbox'],
    restartOnFileChange: true,
    singleRun: true
  });
};
